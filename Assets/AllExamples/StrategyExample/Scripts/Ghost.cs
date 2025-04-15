using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private const float MinDistanceToTarget = 0.05f;

    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;

    private List<Transform> _targets;

    private Transform _currentTarget;

    private ITargetSelector _targetSelector;

    public void Initialize(ITargetSelector targetSelector, List<Transform> targets)
    {
        _targets = targets;
        SetTargetSelector(targetSelector);
    }

    public void SetTargetSelector(ITargetSelector targetSelector)
    {
        _targetSelector = targetSelector;
        UpdateTarget();
    }

    private void Update()
    {
        Vector3 diraction = GetDirectionTo(_currentTarget);

        if (diraction.magnitude <= MinDistanceToTarget)
        {
            UpdateTarget();
            return;
        }

        Vector3 normalizedDiraction = diraction.normalized;

        ProcessMoveTo(normalizedDiraction);

        ProcessRotateTo(normalizedDiraction);
    }

    private void ProcessRotateTo(Vector3 diraction)
    {
        Vector3 xzDiraction = new Vector3(diraction.x, 0, diraction.z);

        Quaternion lookRotation = Quaternion.LookRotation(xzDiraction);
        float step = _rotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
    }

    private void ProcessMoveTo(Vector3 diraction)
    {
        transform.Translate(diraction * _speed * Time.deltaTime, Space.World);
    }

    private Vector3 GetDirectionTo(Transform target) => target.position - transform.position;

    private void UpdateTarget() => _currentTarget = _targetSelector.SelectFrom(_targets);
}

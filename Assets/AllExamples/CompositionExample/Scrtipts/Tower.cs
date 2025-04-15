using UnityEngine;

public class Tower : MonoBehaviour
{
    private DistanceAtackBehaviour _distanceAtackBehaviour;

    public void Initialize(DistanceAtackBehaviour distanceAtackBehaviour)
    {
        _distanceAtackBehaviour = distanceAtackBehaviour;
    }

    public void Attack() => _distanceAtackBehaviour.Attack();
}

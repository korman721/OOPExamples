using UnityEngine;

namespace Homework1617
{
    public class Character : MonoBehaviour
    {
        private const string HorizontalAxisName = "Horizontal";
        private const string VerticalAxisName = "Vertical";

        [SerializeField] private float _speed;
        [SerializeField] private float _rotationSpeed;

        private CharacterController _characterController;
        private Rotator _rotateTo;
        private Mover _mover;

        private float _deadZone = 0.1f;

        private void Awake()
        {
            _rotateTo = new Rotator();
            _mover = new Mover();

            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            Vector3 input = new Vector3(Input.GetAxisRaw(HorizontalAxisName), 0, Input.GetAxisRaw(VerticalAxisName));

            if (input.magnitude <= _deadZone)
                return;

            Vector3 normalized = input.normalized;

            _mover.ProcessMoveTo(normalized, _characterController, _speed);

            _rotateTo.ProcessRotateTo(normalized, _rotationSpeed, transform);
        }
    }
}


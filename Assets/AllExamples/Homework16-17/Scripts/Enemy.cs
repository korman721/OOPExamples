using UnityEngine;

namespace Homework1617
{
    public class Enemy : MonoBehaviour
    {
        private IPeaceBehaviour _peaceBehaviour;
        private IReactBehaviour _reactBehaviour;

        private bool _isPeace = true;
        private bool _isReact = false;

        public void Initialize(IPeaceBehaviour peaceBehaviour, IReactBehaviour reactBehaviour)
        {
            _peaceBehaviour = peaceBehaviour;
            _reactBehaviour = reactBehaviour;
        }

        private void OnTriggerEnter(Collider other)
        {
            Character character = other.GetComponent<Character>();

            if (character != null)
            {
                _isPeace = false;
                _isReact = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            Character character = other.GetComponent<Character>();

            if (character != null)
            {
                _isPeace = true;
                _isReact = false;
            }
        }

        private void Update()
        {
            if (_isPeace)
            {
                _peaceBehaviour.ObjectRests();
            }

            if (_isReact)
            {
                _reactBehaviour.ObjectReacts();
            }
        }
    }
}

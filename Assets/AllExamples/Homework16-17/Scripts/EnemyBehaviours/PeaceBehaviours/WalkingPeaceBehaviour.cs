using UnityEngine;

namespace Homework1617
{
    public class WalkingPeaceBehaviour : BehaviourWithMovement, IPeaceBehaviour
    {
        private const float TimeBeforeChangeDiraction = 1f;

        private Transform _enemyTransform;
        private float _currentTime;
        private Vector3 _moveDiraction;

        public WalkingPeaceBehaviour(Transform enemyTransform) : base(enemyTransform)
        {
            _enemyTransform = enemyTransform;
        }

        public void ObjectRests()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > TimeBeforeChangeDiraction)
            {
                _moveDiraction = GetDiraction();

                _currentTime = 0f;
            }

            Move(_moveDiraction);
        }

        protected override Vector3 GetDiraction() => new Vector3(Random.Range(0f, 1f), 0f, Random.Range(0f, 1f)).normalized;
    }
}
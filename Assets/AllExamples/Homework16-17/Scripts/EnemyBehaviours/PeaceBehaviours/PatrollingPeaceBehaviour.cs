using System.Collections.Generic;
using UnityEngine;

namespace Homework1617
{
    public class PatrollingPeaceBehaviour : BehaviourWithMovement, IPeaceBehaviour
    {
        private const float MinDistanceToTarget = 0.5f;

        private List<Transform> _patrollingPoints;
        private Transform _currentTarget;
        private Transform _enemyTransform;

        public PatrollingPeaceBehaviour(Transform enemyTransform, List<Transform> points) : base(enemyTransform)
        {
            _enemyTransform = enemyTransform;
            _patrollingPoints = points;

            GetRandomPoint();
        }

        public void ObjectRests()
        {
            Vector3 direction = GetDiraction();

            if (direction.magnitude <= MinDistanceToTarget)
                GetRandomPoint();

            Vector3 normalizedDirectionXZ = new Vector3 (direction.x, 0, direction.z).normalized;

            Move(normalizedDirectionXZ);
        }

        private void GetRandomPoint() => _currentTarget = _patrollingPoints[Random.Range(0, _patrollingPoints.Count)];

        protected override Vector3 GetDiraction() => _currentTarget.position - _enemyTransform.position;
    }
}

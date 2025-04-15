using UnityEngine;

namespace Homework1617
{
    public class TargetReactBehaviour : BehaviourWithMovement, IReactBehaviour
    {
        private Transform _enemyTransform;
        private Transform _characterTransform;

        public TargetReactBehaviour(Transform enemyTransform, Transform characterTransform) : base(enemyTransform)
        {
            _enemyTransform = enemyTransform;
            _characterTransform = characterTransform;
        } 

        public void ObjectReacts()
        {
            Vector3 direction = GetDiraction();

            Vector3 xzDiraction = new Vector3(direction.x, 0, direction.z);

            Vector3 normalizedDirection = xzDiraction.normalized;

            Move(normalizedDirection);
        }

        protected override Vector3 GetDiraction() => _characterTransform.position - _enemyTransform.position;
    }
}
using UnityEngine;

namespace Homework1617
{
    public abstract class BehaviourWithMovement
    {
        private Transform _enemyTransform;

        public BehaviourWithMovement(Transform enemyTransform)
        {
            _enemyTransform = enemyTransform;
        }

        protected void Move(Vector3 normalizedDiraction)
        {
            _enemyTransform.Translate(normalizedDiraction * Time.deltaTime, Space.World);
        }

        protected abstract Vector3 GetDiraction();
    }
}

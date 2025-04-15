using UnityEngine;

namespace Homework1617
{
    public class ScaredDieReactBehaviour : IReactBehaviour
    {
        private Transform _enemyTransform;
        private ParticleSystem _dieParticalSystem;

        public ScaredDieReactBehaviour(Transform enemyTransform, ParticleSystem dieParticalSystem)
        {
            _enemyTransform = enemyTransform;
            _dieParticalSystem = dieParticalSystem;
        }

        public void ObjectReacts()
        {
            ParticleSystem dieParticleSystem = Object.Instantiate(_dieParticalSystem, new Vector3(_enemyTransform.position.x, _enemyTransform.position.y, _enemyTransform.position.z), Quaternion.identity);

            dieParticleSystem.Play();

            Object.Destroy(_enemyTransform.gameObject);
        }
    }
}

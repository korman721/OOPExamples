using UnityEngine;

namespace Homework1617
{
    public class EnemyReactBehaviourFactory
    {
        private Transform _enemyTransform;
        private Transform _characterTransform;
        private ParticleSystem _dieParticleSystem;

        public EnemyReactBehaviourFactory(Transform enemyTransform, Transform characterTransform, ParticleSystem dieParticleSystem)
        {
            _enemyTransform = enemyTransform;
            _characterTransform = characterTransform;
            _dieParticleSystem = dieParticleSystem;
        }

        public IReactBehaviour GetEnemyReactBehaviour(EnemyReactBehaviours enemyReactBehaviours)
        {
            switch (enemyReactBehaviours)
            {
                case EnemyReactBehaviours.FearRun:
                    return new FearRunReactBehaviour(_enemyTransform, _characterTransform);

                case EnemyReactBehaviours.Target:
                    return new TargetReactBehaviour(_enemyTransform, _characterTransform);

                case EnemyReactBehaviours.ScaredDie:
                    return new ScaredDieReactBehaviour(_enemyTransform, _dieParticleSystem);

                default:
                    Debug.LogError("Ошибка");
                    return null;
            }
        }
    }
}
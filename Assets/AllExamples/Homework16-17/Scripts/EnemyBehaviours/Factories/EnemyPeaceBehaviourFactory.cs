using System.Collections.Generic;
using UnityEngine;

namespace Homework1617
{
    public class EnemyPeaceBehaviourFactory
    {
        private Transform _enemyTransform;
        private List<Transform> _points;

        public EnemyPeaceBehaviourFactory(Transform enemyTransform, List<Transform> points)
        {
            _enemyTransform = enemyTransform;
            _points = points;
        }

        public IPeaceBehaviour GetEnemyPeaceBehaviour(EnemyPeaceBehaviours enemyPeaceBehaviours)
        {
            switch (enemyPeaceBehaviours)
            {
                case EnemyPeaceBehaviours.Stand:
                    return new StandPeaceBehaviour();

                case EnemyPeaceBehaviours.Patrolling:
                    return new PatrollingPeaceBehaviour(_enemyTransform, _points);

                case EnemyPeaceBehaviours.Walking:
                    return new WalkingPeaceBehaviour(_enemyTransform);

                default:
                    Debug.LogError("Ошибка");
                    return null;
            }
        }
    }
}
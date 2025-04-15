using System.Collections.Generic;
using UnityEngine;

namespace Homework1617
{
    public class SpawnPoint : MonoBehaviour
    {
        [SerializeField] private EnemyPeaceBehaviours _enemyPeaceBehaviours;
        [SerializeField] private EnemyReactBehaviours _enemyReactBehaviours;

        public EnemyPeaceBehaviours EnemyPeaceBehaviour => _enemyPeaceBehaviours;
        public EnemyReactBehaviours EnemyReactBehaviour => _enemyReactBehaviours;
    }
}

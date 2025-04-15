using System.Collections.Generic;
using UnityEngine;

namespace Homework1617
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private Enemy _enemyPrefab;
        [SerializeField] private ParticleSystem _dieParticalSystemPrefab;

        [SerializeField] private Transform _characterTransform;
        [SerializeField] private List<Transform> _patrollingPoints;
        [SerializeField] private List<SpawnPoint> _spawnPoints;

        private IPeaceBehaviour _peaceBehaviour;
        private IReactBehaviour _reactBehaviour;

        private EnemyReactBehaviourFactory _enemyReactBehaviourFactory;
        private EnemyPeaceBehaviourFactory _enemyPeaceBehaviourFactory;

        private void Awake()
        {
            foreach (SpawnPoint spawnPoint in _spawnPoints)
            {
                Enemy enemy = Instantiate(_enemyPrefab, new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z), Quaternion.identity);

                _enemyReactBehaviourFactory = new EnemyReactBehaviourFactory(enemy.transform, _characterTransform, _dieParticalSystemPrefab);
                _enemyPeaceBehaviourFactory = new EnemyPeaceBehaviourFactory(enemy.transform, _patrollingPoints);

                SetBehavioursToEnemy(enemy, spawnPoint.EnemyPeaceBehaviour, spawnPoint.EnemyReactBehaviour);
            }
        }

        private void SetBehavioursToEnemy(Enemy enemy, EnemyPeaceBehaviours enemyPeaceBehaviour, EnemyReactBehaviours enemyReactBehaviour)
        {
            _reactBehaviour = _enemyReactBehaviourFactory.GetEnemyReactBehaviour(enemyReactBehaviour);
            _peaceBehaviour = _enemyPeaceBehaviourFactory.GetEnemyPeaceBehaviour(enemyPeaceBehaviour);

            enemy.Initialize(_peaceBehaviour, _reactBehaviour);
        }
    }
}
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyEnumExample _smallEnemyPrefab;
    [SerializeField] private EnemyEnumExample _mediumEnemyPrefab;
    [SerializeField] private EnemyEnumExample _largeEnemyPrefab;

    public void SpawnTo(Vector3 position, EnemyTypes enemyType)
    {
        switch (enemyType)
        {
            case EnemyTypes.Small:
                Instantiate(_smallEnemyPrefab, position, Quaternion.identity);
                break;

            case EnemyTypes.Medium:
                Instantiate(_mediumEnemyPrefab, position, Quaternion.identity);
                break;

            case EnemyTypes.Large:
                Instantiate(_largeEnemyPrefab, position, Quaternion.identity);
                break;

            default:
                Debug.LogError("Спавн такого врага не поддердивается");
                break;
        }
    }
}

using UnityEngine;

public class EnumTest : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private EnemySpawner _enemySpawner;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            _enemySpawner.SpawnTo(_position, EnemyTypes.Small);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            _enemySpawner.SpawnTo(_position, EnemyTypes.Medium);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            _enemySpawner.SpawnTo(_position, EnemyTypes.Large);
    }
}

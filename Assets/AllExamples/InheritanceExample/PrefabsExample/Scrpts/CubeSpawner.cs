using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Vector3 spawnPosition = new Vector3(Random.Range(_minX, _maxX), 0, 0);

            GameObject currentCube = Instantiate(_cubePrefab, spawnPosition, Quaternion.identity);
            currentCube.transform.position += Vector3.up * 3;
        }
    }
}

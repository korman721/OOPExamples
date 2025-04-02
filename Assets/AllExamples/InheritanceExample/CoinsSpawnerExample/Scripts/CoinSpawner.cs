using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private float _cooldown;

    [SerializeField] private List<Coin> _coinPrefabs;

    private float _time;

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _cooldown)
        {
            List<SpawnPoint> emptyPoints = GetEmptyPoints();

            if (emptyPoints.Count == 0)
            {
                _time = 0;
                return;
            }

            SpawnPoint spawnPoint = emptyPoints[Random.Range(0, emptyPoints.Count)];

            Coin coin = Instantiate(_coinPrefabs[Random.Range(0, _coinPrefabs.Count)], spawnPoint.Position, Quaternion.identity);

            spawnPoint.Occupy(coin);

            _time = 0;
        }
    }

    private List<SpawnPoint> GetEmptyPoints()
    {
        List<SpawnPoint> emptyPoints = new List<SpawnPoint>();

        foreach (SpawnPoint spawnPoint in _spawnPoints)
            if (spawnPoint.IsEmpty)
                emptyPoints.Add(spawnPoint);

        return emptyPoints;
    }
}

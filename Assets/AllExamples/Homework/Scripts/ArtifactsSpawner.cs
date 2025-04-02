using System.Collections.Generic;
using UnityEngine;

public class ArtifactsSpawner : MonoBehaviour
{
    [SerializeField] private List<ArtifactSpawnPoint> _artifactSpawnPoints;
    [SerializeField] private List<Artifact> _artifactsPrefabs;

    [SerializeField] private float _timeToSpawn;

    private float _currentTimeToSpawn;

    private void Awake()
    {
        foreach (ArtifactSpawnPoint artifactSpawnPoint in _artifactSpawnPoints)
        {
            SpawnArtifact(artifactSpawnPoint);
        }

        _currentTimeToSpawn = _timeToSpawn;
    }

    private void Update()
    {
        if (_currentTimeToSpawn <= 0)
        {
            List<ArtifactSpawnPoint> emptyArtifactSpawnPoint = GetEmptySpawnPoints();

            if (emptyArtifactSpawnPoint.Count == 0)
            {
                _currentTimeToSpawn = _timeToSpawn;
                return;
            }

            ArtifactSpawnPoint randomEmptySpawnPoint = emptyArtifactSpawnPoint[Random.Range(0, emptyArtifactSpawnPoint.Count)];

            SpawnArtifact(randomEmptySpawnPoint);

            _currentTimeToSpawn = _timeToSpawn;
        }

        _currentTimeToSpawn -= Time.deltaTime;
    }

    private List<ArtifactSpawnPoint> GetEmptySpawnPoints()
    {
        List<ArtifactSpawnPoint> emptyArtifactSpawnPoint = new List<ArtifactSpawnPoint>();

        foreach (ArtifactSpawnPoint artifactSpawnPoint in _artifactSpawnPoints)
        {
            if (artifactSpawnPoint.IsEmpty)
            {
                emptyArtifactSpawnPoint.Add(artifactSpawnPoint);
            }
        }

        return emptyArtifactSpawnPoint;
    }

    private void SpawnArtifact(ArtifactSpawnPoint artifactSpawnPoint)
    {
        Artifact artifact = Instantiate(_artifactsPrefabs[Random.Range(0, _artifactsPrefabs.Count)], artifactSpawnPoint.Position, Quaternion.identity);
        artifactSpawnPoint.Occupy(artifact);
    }
}

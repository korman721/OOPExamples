using System.Collections.Generic;
using UnityEngine;

public class StrategyExample : MonoBehaviour
{
    [SerializeField] private Ghost _ghostPrefab;

    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private List<Transform> _targets;

    private List<Ghost> _spawnedGhosts = new();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Ghost ghost = CreateGhost();
            ghost.Initialize(new HighestTargetSelector(), _targets);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Ghost ghost = CreateGhost();
            ghost.Initialize(new LowerTargetSelector(), _targets);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Ghost ghost = CreateGhost();
            ghost.Initialize(new DistanceTargetSelector(ghost.transform), _targets);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            foreach (Ghost ghost in _spawnedGhosts)
            {
                ghost.SetTargetSelector(new HighestTargetSelector());
            }
        }
    }

    private Ghost CreateGhost()
    {
        Ghost ghost = Instantiate(_ghostPrefab, _spawnPoint.position, Quaternion.identity);
        _spawnedGhosts.Add(ghost);
        return ghost;
    }
}

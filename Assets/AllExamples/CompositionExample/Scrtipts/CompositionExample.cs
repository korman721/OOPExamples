using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositionExample : MonoBehaviour
{
    [SerializeField] private Humanoid _humanoidPrefab;
    [SerializeField] private BonusBox _boxPrefab;
    [SerializeField] private Tower _towerPrefab;

    private void Awake()
    {
        Humanoid dwarf = Instantiate(_humanoidPrefab);
        dwarf.Initialize(new MelleAtackBehaviour(), new ArmorHealth(5, 50));

        Humanoid elf = Instantiate(_humanoidPrefab);
        elf.Initialize(new DistanceAtackBehaviour(), new AghilityHealth(2, 30));

        Humanoid robot = Instantiate(_humanoidPrefab);
        robot.Initialize(new DistanceAtackBehaviour(), new ArmorHealth(5, 50));

        BonusBox box = Instantiate(_boxPrefab);
        box.Initialize(new Health(60));

        Tower tower = Instantiate(_towerPrefab);
        tower.Initialize(new DistanceAtackBehaviour());

        TakeDamageTo(box);
        TakeDamageTo(robot);

    }

    private void TakeDamageTo(IDamageable damageable)
    {
        damageable.TakeDamage(100);
    }
}

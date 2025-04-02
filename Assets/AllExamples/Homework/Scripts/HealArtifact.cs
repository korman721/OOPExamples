using UnityEngine;

public class HealArtifact : Artifact
{
    [SerializeField] private int _healValue;

    public override void Use(Hero hero)
    {
        if (_healValue < 0)
            return;

        hero.Health += _healValue;

        Debug.Log($"Heal: +{_healValue}; Health: {hero.Health}");

        base.Use(hero);
    }
}

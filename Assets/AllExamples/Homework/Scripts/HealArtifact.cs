using UnityEngine;

public class HealArtifact : Artifact
{
    [SerializeField, Range(0, 100)] private int _healValue;

    public override void Use(Hero hero)
    {
        hero.Health += _healValue;

        Debug.Log($"Heal: +{_healValue}; Health: {hero.Health}");

        base.Use(hero);
    }
}

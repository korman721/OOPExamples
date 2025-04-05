using UnityEngine;

public class AcceleratorArtifact : Artifact
{
    [SerializeField, Range(0, 1000)] private int _accelerationSpeedValue;
    [SerializeField, Range(0, 1000)] private int _accelerationSpeedRotationValue;

    public override void Use(Hero hero)
    {
        hero.MovementSpeed += _accelerationSpeedValue;
        hero.RotationSpeed += _accelerationSpeedRotationValue;

        base.Use(hero);
    }
}

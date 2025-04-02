using UnityEngine;

public class AcceleratorArtifact : Artifact
{
    [SerializeField] private int _accelerationSpeedValue;
    [SerializeField] private int _accelerationSpeedRotationValue;

    public override void Use(Hero hero)
    {
        if (_accelerationSpeedValue < 0)
            return;

        hero.MovementSpeed += _accelerationSpeedValue;
        hero.RotationSpeed += _accelerationSpeedRotationValue;

        base.Use(hero);
    }
}

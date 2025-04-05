using UnityEngine;

public class ShotArtifact : Artifact
{
    [SerializeField, Range(0, 100)] private float _force;

    [SerializeField] private Rigidbody _bullet;

    public override void Use(Hero hero)
    {
        GameObject bullet = Instantiate(_bullet.gameObject, transform.position, Quaternion.identity);

        bullet.GetComponent<Rigidbody>().AddForce(-hero.transform.forward * _force, ForceMode.Impulse);

        base.Use(hero);
    }
}

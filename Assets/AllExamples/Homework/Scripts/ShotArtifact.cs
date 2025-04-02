using UnityEngine;

public class ShotArtifact : Artifact
{
    [SerializeField] private float _force;

    [SerializeField] private GameObject _bullet;

    public override void Use(Hero hero)
    {
        GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.identity);

        bullet.GetComponent<Rigidbody>().AddForce(-hero.transform.forward * _force, ForceMode.Impulse);

        base.Use(hero);
    }
}

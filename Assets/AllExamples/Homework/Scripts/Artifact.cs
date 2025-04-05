using UnityEngine;

public abstract class Artifact : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystemPrefab;

    private float _timeBeforeDestroyParticleSystem = 5f;

    public virtual void Use(Hero hero)
    {
        LeaveParticalEffect();

        Destroy(gameObject);
    }

    private void LeaveParticalEffect()
    {
        ParticleSystem particleSystem = Instantiate(_particleSystemPrefab, transform.position, Quaternion.identity);
        particleSystem.Play();
        Destroy(particleSystem.gameObject, _timeBeforeDestroyParticleSystem);
    }
}

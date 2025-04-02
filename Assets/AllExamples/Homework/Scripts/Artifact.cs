using UnityEngine;

public abstract class Artifact : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystemPrefab;

    private Vector3 _pickUpScale = new Vector3(0.45f, 0.45f, 0.45f);
    private float _timeBeforeDestroyParticleSystem = 5f;

    public virtual void Use(Hero hero)
    {
        LeaveParticalEffect();

        Destroy(gameObject);
    }

    public void PickUp(Transform pickUpPoint)
    {
        transform.position = pickUpPoint.position;
        transform.localScale = _pickUpScale;
        gameObject.transform.SetParent(pickUpPoint);
    }

    private void LeaveParticalEffect()
    {
        ParticleSystem particleSystem = Instantiate(_particleSystemPrefab, transform.position, Quaternion.identity);
        particleSystem.Play();
        Destroy(particleSystem.gameObject, _timeBeforeDestroyParticleSystem);
    }
}

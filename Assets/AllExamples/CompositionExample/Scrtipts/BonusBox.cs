using UnityEngine;

public class BonusBox : MonoBehaviour, IDamageable
{
    private Health _health;

    public void Initialize(Health health)
    {
        _health = health;
    }

    public void TakeDamage(int damage) => _health.Reduce(damage);
}

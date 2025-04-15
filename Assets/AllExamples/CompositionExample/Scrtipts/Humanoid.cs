using UnityEngine;

public class Humanoid : MonoBehaviour, IDamageable
{
    private IAttackBehaviour _attackBehaviour;
    private Health _health;

    public void Initialize(IAttackBehaviour attackBehaviour, Health health)
    {
        _attackBehaviour = attackBehaviour;
        _health = health;
    }

    public void Attack() => _attackBehaviour.Attack();

    public void TakeDamage(int damage) => _health.Reduce(damage);
}

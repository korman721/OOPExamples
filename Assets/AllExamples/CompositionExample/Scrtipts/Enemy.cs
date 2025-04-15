using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private int _health;

    private void Awake()
    {
        _health = _maxHealth;
    }

    public virtual void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Debug.LogError("Damage < 0");
            return;
        }

        _health -= damage;

        if (_health < 0)
        {
            _health = 0;
            Debug.Log("I DIE");
        }

        Debug.Log(_health);
    }

    public abstract void Attack();
}

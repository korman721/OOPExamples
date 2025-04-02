using UnityEngine;

public abstract class Ork
{
    public Ork(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public string Name { get; }
    public int Health { get; protected set; }
    public int Damage { get; protected set; }

    public virtual bool IsAlive => Health > 0;

    public virtual void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Debug.LogError("_damage < 0");
            return;
        }

        Health -= damage;

        if (Health <= 0)
        {
            Health = 0;
            Debug.Log($"О нет я {Name} умер");
        }
    }

    public abstract void IssueCry();
}

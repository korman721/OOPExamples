using UnityEngine;

public class Elf : Enemy
{
    [SerializeField] private int _agility;

    public override void TakeDamage(int damage)
    {
        damage /= _agility;

        base.TakeDamage(damage);
    }

    public override void Attack()
    {
        Debug.Log("DISTANCE ATTACK");
    }
}

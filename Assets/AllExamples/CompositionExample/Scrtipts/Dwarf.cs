using UnityEngine;

public class Dwarf : Enemy
{
    [SerializeField] private int _armor;

    public override void TakeDamage(int damage)
    {
        damage -= _armor;

        if (damage < 0)
            damage = 0;

        base.TakeDamage(damage);
    }

    public override void Attack()
    {
        Debug.Log("CLOSE ATTACK");
    }
}

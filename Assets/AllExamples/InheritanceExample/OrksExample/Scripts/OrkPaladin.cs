using UnityEngine;

public class OrkPaladin : Ork
{
    private int _heal;

    private int _armor;

    public OrkPaladin(string name, int health, int damage, int heal, int armor) : base(name, health, damage)
    {
        _heal = heal;
        _armor = armor;
    }

    public override bool IsAlive => base.IsAlive && _armor > 0;

    public override void TakeDamage(int damage)
    {
        damage -= _armor;

        if (damage < 0)
            damage = 0;

        base.TakeDamage(damage);
    }

    public void Heal()
    {
        Debug.Log("Лечение использовано");

        Health += _heal;
    }

    public override void IssueCry() => Debug.Log("Paladin Cry");
}

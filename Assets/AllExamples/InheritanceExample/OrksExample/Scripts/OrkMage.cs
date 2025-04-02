using UnityEngine;

public class OrkMage : Ork
{
    private int _damageMultiplier;

    public OrkMage(string name, int health, int damage, int damageMultiplier) : base(name, health, damage)
    {
        _damageMultiplier = damageMultiplier;
    }

    public void CastSpell()
    {
        Debug.Log("Суперспособность использована");

        Damage *= _damageMultiplier;
    }

    public override void IssueCry() => Debug.Log("Mage Cry");
}

using UnityEngine;

public class Health
{
    public Health(int value)
    {
        Value = value;
    }

    public int Value { get; private set; }

    public virtual void Reduce(int value)
    {
        if (value < 0)
        {
            Debug.LogError("Damage < 0");
            return;
        }

        Value -= value;

        if (Value < 0)
        {
            Value = 0;
            Debug.Log("I DIE");
        }

        Debug.Log(Value);
    }
}

public class ArmorHealth : Health
{
    private int _armor;

    public ArmorHealth(int armor, int value) : base(value)
    {
        _armor = armor;
    }

    public override void Reduce(int value)
    {
        value -= _armor;

        if (value < 0)
            value = 0;

        base.Reduce(value);
    }
}

public class AghilityHealth : Health
{
    private int _agility;

    public AghilityHealth(int agility, int value) : base(value)
    {
        _agility = agility;
    }

    public override void Reduce(int value)
    {
        value /= _agility;

        base.Reduce(value);
    }
}

using UnityEngine;

public class StandartCoin : Coin
{
    [SerializeField] private int _value;

    public override int Value => _value;
}

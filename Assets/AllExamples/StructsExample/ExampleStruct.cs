using UnityEngine;

public struct ExampleStruct
{
    private int _value;

    public ExampleStruct(int value)
    {
        _value = value;
    }

    public int Value => _value;

    public void Add(int value)
    {
        _value += value;
    }
}

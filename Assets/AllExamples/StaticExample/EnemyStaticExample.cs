using UnityEngine;

public class EnemyStaticExample 
{
    public int Health;
    public static int MaxHealth;

    static EnemyStaticExample()
    {
        MaxHealth = 100;
        Debug.Log("Static Constructor");
    }
    public EnemyStaticExample(int health)
    {
        Health = health;
        Debug.Log("Usual Constructor");
    }

    public bool CanAddHealth() => Health < MaxHealth;

    public static void AddHealth( int health)
    {
        //if (CanAddHealth())

        //Health += health;
    }
}

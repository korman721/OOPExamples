using UnityEngine;

public interface IAttackBehaviour 
{
    void Attack();
}

public class MelleAtackBehaviour : IAttackBehaviour
{
    public void Attack()
    {
        Debug.Log("CLOSE ATTACK");
    }
}

public class DistanceAtackBehaviour : IAttackBehaviour
{
    public void Attack()
    {
        Debug.Log("DISTANCE ATTACK");
    }
}
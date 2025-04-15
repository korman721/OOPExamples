using UnityEngine;


public class Mover
{
    public void ProcessMoveTo(Vector3 diraction, Rigidbody rigidbody, float speed)
    {
        rigidbody.AddForce(diraction * speed);
    }
}

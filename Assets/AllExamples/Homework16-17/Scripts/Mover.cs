using UnityEngine;

namespace Homework1617
{
    public class Mover
    {
        public void ProcessMoveTo(Vector3 diraction, CharacterController characterController, float speed)
        {
            characterController.Move(diraction * speed * Time.deltaTime);
        }
    }
}

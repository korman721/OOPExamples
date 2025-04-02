using UnityEngine;

public class Rotator
{
    public void ProcessRotateTo(Vector3 diraction, Transform transform, float rotationSpeed)
    {
        Quaternion lookRotation = Quaternion.LookRotation(-diraction);
        float step = rotationSpeed * Time.fixedDeltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
    }
}

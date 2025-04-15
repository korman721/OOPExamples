using System.Collections.Generic;
using UnityEngine;

public class LowerTargetSelector : ITargetSelector
{
    public Transform SelectFrom(List<Transform> targets)
    {
        Transform selectedTarget = targets[0];

        foreach (Transform target in targets)
            if (target.position.y < selectedTarget.position.y)
                selectedTarget = target;

        return selectedTarget;
    }
}

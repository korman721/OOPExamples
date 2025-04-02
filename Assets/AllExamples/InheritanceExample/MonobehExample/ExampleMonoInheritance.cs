using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMonoInheritance : MonoBehaviour
{
    private void Start()
    {
        //MonoBehaviourClass monoBehaviourClass = new MonoBehaviourClass(10);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            gameObject.AddComponent<MonoBehaviourClass>();
    }
}

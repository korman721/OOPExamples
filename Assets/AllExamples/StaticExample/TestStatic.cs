using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStatic : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Program Starts");
        EnemyStaticExample enemy = new EnemyStaticExample(10);

        //EnemyStaticExample enemy1 = new EnemyStaticExample();
        //EnemyStaticExample enemy2 = new EnemyStaticExample();

        //enemy1.Health = 10;
        //enemy2.Health = 20;

        //EnemyStaticExample.MaxHealth = 100;

        //Debug.Log(enemy1.CanAddHealth());
        //Debug.Log(enemy2.CanAddHealth());

        //EnemyStaticExample.MaxHealth = 15;

        //Debug.Log(enemy1.CanAddHealth());
        //Debug.Log(enemy2.CanAddHealth());
    }
}

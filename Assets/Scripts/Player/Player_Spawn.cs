using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_Spawn : MonoBehaviour

    // Spawn Player
{
    private void Awake()
    {
        if
            {
            GameObject.FindWithTag("Player").transform.position = transform.position;
        }
    }
}

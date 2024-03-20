using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Keep all elements selected
public class Game_Manager : MonoBehaviour
{
    public GameObject[] objects;
    void Awake()
    {
        foreach (var element in objects)
        {
            DontDestroyOnLoad(element);
        }
    }
}
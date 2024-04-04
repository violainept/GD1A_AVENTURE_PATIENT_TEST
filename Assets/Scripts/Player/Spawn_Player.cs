using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Player : MonoBehaviour
{
    public int spawnPointRef;
    public Player_Checks_Scene getIndex;
    public int sceneIndex;
    private void Awake()
    {
        getIndex = GameObject.FindWithTag("Player").GetComponent<Player_Checks_Scene>();
        sceneIndex = getIndex.previousSceneIndex;
        if (sceneIndex == spawnPointRef)
        {
            GameObject.FindWithTag("Player").transform.position = transform.position;
        }
    }
}
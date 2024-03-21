using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Spawn : MonoBehaviour
{
    public int spawnPointRef;
    public Player_SceneChange getIndex;
    public int sceneIndex;
    private void Awake()
    {
        getIndex = GameObject.FindWithTag("Player").GetComponent<Player_SceneChange>();
        sceneIndex = getIndex.previousSceneIndex;
        if (sceneIndex == spawnPointRef)
        {
            GameObject.FindWithTag("Player").transform.position = transform.position;
        }
    }
}
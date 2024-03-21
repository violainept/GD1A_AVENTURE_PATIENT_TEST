using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_SceneChange : MonoBehaviour
{
    public int previousSceneIndex;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Scene_Change"))
        {
            previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
        }
    }
}

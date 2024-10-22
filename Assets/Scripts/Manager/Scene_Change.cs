using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour
{
    public string sceneName;

    // When Player collide with it, load an other scene
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}


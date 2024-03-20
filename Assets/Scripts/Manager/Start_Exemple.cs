using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start_Exemple : MonoBehaviour
{
    public string sceneName;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}

using UnityEngine;

public class Collectible_Key_001 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AddKeyToInventory();
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("KeyPickedUp", 1);
        }
    }

    void AddKeyToInventory()
    {   
    }

    void Start()
    {
        if (PlayerPrefs.GetInt("KeyPickedUp", 0) == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
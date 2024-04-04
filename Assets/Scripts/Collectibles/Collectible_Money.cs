using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible_Money : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player_Controller>().CollectMoney();
            Destroy(collision.gameObject);
        }
    }
}

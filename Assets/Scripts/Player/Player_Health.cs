using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour
{
    public int health;
    public int maxHealth = 5;

    public SpriteRenderer player;
    public Player_Controller playerController;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            player.enabled = false;
            playerController.enabled = false;
        }
    }
}

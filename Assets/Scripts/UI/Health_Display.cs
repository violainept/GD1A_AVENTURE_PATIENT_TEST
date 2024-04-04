using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Display : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;

    public Player_Health playerHealth;

    void Update()
    {
        health = playerHealth.health;
        maxHealth = playerHealth.maxHealth;


        for (int i = 0; i < hearts.Length; i++)
        {
            if(i <  health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}

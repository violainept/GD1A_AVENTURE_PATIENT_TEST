using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private float distance;

    void Start()
    {

    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);



        if (distance > 4)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.fixedDeltaTime);
        }
    }
}


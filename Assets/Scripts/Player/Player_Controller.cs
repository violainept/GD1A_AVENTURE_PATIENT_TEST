using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    private float _speed = 6f;
    float horizontal;
    float vertical;

    int money = 0;


    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }


    void Update()
    {
        PlayerMovements();
    }

    //////////////// Movements ////////////////
    private void PlayerMovements()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.right * horizontal * _speed * Time.deltaTime);
        transform.Translate(Vector3.up * vertical * _speed * Time.deltaTime);
    }

    //////////////// Collectibles //////////////// 
    public void CollectMoney()
    {
        money += 1;
    }
}
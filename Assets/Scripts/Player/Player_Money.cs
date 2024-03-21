using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Money : MonoBehaviour
{
    int money = 0;
    public void CollectMoney()
    {
        money += 1;
    }
}

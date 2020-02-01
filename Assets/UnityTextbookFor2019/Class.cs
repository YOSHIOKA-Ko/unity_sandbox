using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + " damage to target.");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log("Get " + damage + " damage.");
    }
}

public class Class : MonoBehaviour
{
    private void Start()
    {
        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);
    }
}

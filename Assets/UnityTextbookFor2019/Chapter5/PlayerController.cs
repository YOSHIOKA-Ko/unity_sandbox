using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            player.transform.Translate(-3, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.transform.Translate(3, 0, 0);
        }
    }

    public void LButtonDown()
    {
        player.transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        player.transform.Translate(3, 0, 0);
    }
}

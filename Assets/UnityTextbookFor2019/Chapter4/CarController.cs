using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float speed = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.speed = .2f;
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= .98f;
    }
}

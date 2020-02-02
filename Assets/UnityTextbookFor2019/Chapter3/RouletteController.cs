using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    private float rotateSpeed = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotateSpeed = 10;
            Debug.Log("Set speed" + rotateSpeed);
        }

        transform.Rotate(0, 0, this.rotateSpeed);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float speed = 0;
    private Vector2 startPosition;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPosition = Input.mousePosition;
            Debug.Log(startPosition);
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPosition = Input.mousePosition;
            Debug.Log(endPosition);
            float swipeLength = endPosition.x - this.startPosition.x;

            this.speed = swipeLength / 500.0f;
            Debug.Log("Swipe length: " + swipeLength + " / First speed: " + speed);
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= .98f;
    }
}

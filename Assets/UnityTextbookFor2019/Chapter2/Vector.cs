using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("List 2-30: Add a vector");
        Vector2 playerPos = new Vector2(3.0f,4.0f);
        playerPos.x += +8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);

        Debug.Log("List 2-31: Subtract a vector");
        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);
    }
}

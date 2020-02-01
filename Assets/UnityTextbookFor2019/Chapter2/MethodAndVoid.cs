using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodAndVoid: MonoBehaviour
{
    void SayHello()
    {
        Debug.Log("Hello");
    }

    private void Start()
    {
        SayHello();
    }
}

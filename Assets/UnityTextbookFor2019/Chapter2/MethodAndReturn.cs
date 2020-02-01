using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodAndReturn : MonoBehaviour
{
    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    private void Start()
    {
        int answer;
        answer = Add(2, 3);
        Debug.Log(answer);

        // 変数を引数にあてることもできる
        int num1 = 20;
        int num2 = 30;
        answer = Add(num1, num2);
        Debug.Log(answer);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStatement : MonoBehaviour
{
    void Start()
    {
        Debug.Log("List 2-14: if");
        int herbNum = 1;
        if (herbNum == 1)
        {
            Debug.Log("Gain 5 life.");
        }

        Debug.Log("List 2-15: if else");
        int hp = 200;
        if (hp >= 100)
        {
            Debug.Log("Attack!");
        }
        else
        {
            Debug.Log("Block!");
        }

        Debug.Log("List 2-16: Connect if else");
        int mp = 180;
        if (mp <= 50)
        {
            Debug.Log("Escape!");
        }
        else if (mp >= 200)
        {
            Debug.Log("Attack!");
        }
        else
        {
            Debug.Log("Block!");
        }

        Debug.Log("List 2-17: Variable scope");
        int x = 1;
        if (x == 1)
        {
            int y = 2;
            Debug.Log(x);
            Debug.Log(y);
        }
//        Debug.Log(y);
//        変数yの宣言がスコープ外のため，エラーとなって実行不可能

        Debug.Log("List 2-18: for");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

        Debug.Log("List 2-19: Even number");
        for (int i = 0; i < 10; i += 2)
        {
            Debug.Log(i);
        }

        Debug.Log("List 2-20: Number scope");
        for (int i = 3; i <= 5; i++)
        {
            Debug.Log(i);
        }

        Debug.Log("List 2-21: Count down");
        for (int i = 3; i >= 0; i--)
        {
            Debug.Log(i);
        }

        Debug.Log("List 2-22: Number sum");
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }

        Debug.Log(sum);
    }
}
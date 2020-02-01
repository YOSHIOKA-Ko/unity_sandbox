using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    void Start()
    {
        Debug.Log("List 2-23: Array");
        int[] array = new int[5];

        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)
        {
           Debug.Log(array[i]);
        }

        Debug.Log("List 2-24: Omit array");
        int[] points = {83, 99, 52, 93, 15};

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] >= 90)
            {
                Debug.Log(points[i]);
            }
        }

        Debug.Log("List 2-25: Omit array");
        int[] coins = {83, 99, 52, 93, 15};

        int sum = 0;
        for (int i = 0; i < coins.Length; i++)
        {
            sum += points[i];
        }

        int int_average = sum / points.Length;
        Debug.Log(int_average);

        // 整数同士の計算は，小数点以下が切り捨てられた結果になる
        // 以下はfloat値を計算に混ぜることで，小数点以下も求める方法
        float float_avarage = 1.0f * sum / points.Length;
        Debug.Log(float_avarage);
    }
}

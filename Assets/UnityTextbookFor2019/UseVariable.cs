using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseVariable : MonoBehaviour
{
    void Start()
    {
        int age;
        age = 30;
        Debug.Log(age);

        float height1 = 160.5f;
        float height2;
        height2 = height1;
        Debug.Log(height2);

        string name;
        name = "YOSHIOKA Ko";
        Debug.Log(name);

        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        answer = 3 - 4;
        Debug.Log(answer);

        answer = 5 * 6;
        Debug.Log(answer);

        answer = 8 / 4;
        Debug.Log(answer);

        int n1 = 8;
        int n2 = 9;
        int answer2;
        answer2 = n1 + n2;
        Debug.Log(answer2);

        int answer3 = 10;
        answer3 += 5;
        Debug.Log(answer3);

        int answer4 = 10;
        answer4++;
        Debug.Log(answer4);

        string str1 = "Happy ";
        string str2 = "birthday";
        string message;

        message = str1 + str2;
        Debug.Log(message);

        str1 += str2;
        Debug.Log(str1);

        string str = "Happy ";
        int num = 123;

        message = str + num;
        Debug.Log(message);
    }
}

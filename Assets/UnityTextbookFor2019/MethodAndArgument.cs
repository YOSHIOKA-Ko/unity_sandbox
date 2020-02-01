using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodAndArgument: MonoBehaviour
{
    void CallName(string name)
    {
        Debug.Log("Hello " + name);
    }

    private void Start()
    {
        CallName("YOSHIOKA, Ko");

        // 引数のあるメソッドを呼び出す場合，必ず対になる引数を渡す必要がある
        // 以下のように空で呼び出そうとすればエラーになる
        // CallName();
    }
}

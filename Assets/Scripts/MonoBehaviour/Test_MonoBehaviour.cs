using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_MonoBehaviour : MonoBehaviour
{
    aaa A;
    bbb B;
    ccc C;
    
    void Start()
    {
        A = new aaa();            // C# での通常のインスタンス化
        B = GetComponent<bbb>();  // MonoBehaviour がついてるなら基本はこう
        C = new ccc();            // MonoBehaviour がついていても一応 new でいける ( 警告は出るよ )

        A.function1();
        B.function1();
        C.function1();
    }

    // テスト用
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) A = new aaa();
        if (Input.GetKey(KeyCode.F) && Input.GetKeyDown(KeyCode.A)) A.function1();
        if (Input.GetKey(KeyCode.F) && Input.GetKeyDown(KeyCode.B)) B.function1();
        if (Input.GetKey(KeyCode.F) && Input.GetKeyDown(KeyCode.C)) C.function1();
    }
}

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
        A = new aaa();            // C# �ł̒ʏ�̃C���X�^���X��
        B = GetComponent<bbb>();  // MonoBehaviour �����Ă�Ȃ��{�͂���
        C = new ccc();            // MonoBehaviour �����Ă��Ă��ꉞ new �ł����� ( �x���͏o��� )

        A.function1();
        B.function1();
        C.function1();
    }

    // �e�X�g�p
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) A = new aaa();
        if (Input.GetKey(KeyCode.F) && Input.GetKeyDown(KeyCode.A)) A.function1();
        if (Input.GetKey(KeyCode.F) && Input.GetKeyDown(KeyCode.B)) B.function1();
        if (Input.GetKey(KeyCode.F) && Input.GetKeyDown(KeyCode.C)) C.function1();
    }
}

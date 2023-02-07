using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Interface_Pro : MonoBehaviour
{
    IShape shape;

    void Start()
    {
        Test();
    }

    void Test()
    {
        shape = GetComponent<Rectangle_Pro>();
        ShowArea(shape);

        shape = GetComponent<Circle_Pro>();
        ShowArea(shape);
    }

    void ShowArea(IShape shape)
    {
        Debug.Log(shape.Area());
    }
    //�S�R�Ⴄ�^�ɑ΂��ē����������������������߂ɁA���^��1��̒��ۓx�� IShape�C���^�[�t�F�C�X �ł܂Ƃ߂Ă���B
        
    //Ishape�^ �ɂ�Area()�֐� �������Ƃ���̂ŉ������Ȃ��B
        
    //��������̕K�v�������B
}
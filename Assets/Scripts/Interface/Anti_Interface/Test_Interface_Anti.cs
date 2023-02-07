using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Interface_Anti : MonoBehaviour
{
    object shape;

    void Start() 
    {
        Test();
    }

    void Test()
    {
        shape = GetComponent<Rectangle_Anti>();
        ShowArea(shape);

        shape = GetComponent<Circle_Anti>();
        ShowArea(shape);
    }

    void ShowArea(object shape)
    {        
        if (shape is Rectangle_Anti shapeR)
            Debug.Log(shapeR.Area());

        if (shape is Circle_Anti shapeC)
            Debug.Log(shapeC.Area());
    }
    //�S�R�Ⴄ�^�ɑ΂��ē����������������������߂ɁA���^���ŋ����ۓx�� object�^ �ł܂Ƃ߂Ă���B
        
    //�������A
    //Debug.Log(shape.Area());
    //���������ƁAobject�^ �� Area()�֐� �Ȃ�Ė����̂ŃG���[�B
        
    //Area() �����݂���^�܂ŋ�̓G�Ɏw�肵�Ȃ��� Area() ���ĂׂȂ��̂ŁA�^���聕�^�ϊ��̂��߂ɏ������򂪕K�v�B
    //�}�`�̎�ނ𑝂₷���Ƃɏ�������ǉ��B
}
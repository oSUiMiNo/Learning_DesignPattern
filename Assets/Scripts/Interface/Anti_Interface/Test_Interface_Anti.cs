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
    //全然違う型に対して同じ処理をしたかったために、両型を最強抽象度の object型 でまとめている。
        
    //しかし、
    //Debug.Log(shape.Area());
    //こう書くと、object型 に Area()関数 なんて無いのでエラー。
        
    //Area() が存在する型まで具体敵に指定しないと Area() を呼べないので、型判定＆型変換のために条件分岐が必要。
    //図形の種類を増やすごとに条件分岐追加。
}
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
    //全然違う型に対して同じ処理をしたかったために、両型を1つ上の抽象度の IShapeインターフェイス でまとめている。
        
    //Ishape型 にはArea()関数 がちゃんとあるので何も問題ない。
        
    //条件分岐の必要が無い。
}
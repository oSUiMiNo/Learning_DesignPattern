using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bbb : MonoBehaviour
{
// ************ ゲームオブジェクトにアタッチしていないと動かない処理 ************
    void Start()
    {
        Debug.Log("bbbのスタート");
    }
    void Update()
    {
        //Debug.Log("bbbのアップデート");
    }
// ******************************************************************************


    public void function1()
    {
        Debug.Log("bbbの関数1");
    }

    public void function2()
    {
        Debug.Log("bbbの関数2");
    }

    public void function3()
    {
        Debug.Log("bbbの関数3");
    }
}

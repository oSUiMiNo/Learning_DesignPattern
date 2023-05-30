using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccc : MonoBehaviour
{
// ************ ゲームオブジェクトにアタッチしていないと動かない処理 ************
    void Start()
    {
        Debug.Log("cccのスタート");
    }
    void Update()
    {
        //Debug.Log("bbbのアップデート");
    }
// ******************************************************************************


    public void function1()
    {
        Debug.Log("cccの関数1");
    }

    public void function2()
    {
        Debug.Log("cccの関数2");
    }

    public void function3()
    {
        Debug.Log("cccの関数3");
    }
}

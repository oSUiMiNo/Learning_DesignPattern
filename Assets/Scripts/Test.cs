using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    GameObject obj;

    void Start()
    {
        obj = GameObject.Find("Obj");
    }

    void Update()
    {
        obj.transform.localPosition += new Vector3(1, 0, 0) * 0.01f;
    }
}

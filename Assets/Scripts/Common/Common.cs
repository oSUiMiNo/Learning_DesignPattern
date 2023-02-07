using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common : MonoBehaviour
{
    public static Common inst;
    private void Awake()
    {
        inst = this;
        //if (inst == null)
        //{
        //    inst = this;
        //    DontDestroyOnLoad(gameObject);
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}

        Init();
    }

    public Member member1;
    public Member member2;

    private void Init()
    {
        member1 = GameObject.Find("Character1").GetComponent<Member>();
        member2 = GameObject.Find("Character2").GetComponent<Member>();
    }

}

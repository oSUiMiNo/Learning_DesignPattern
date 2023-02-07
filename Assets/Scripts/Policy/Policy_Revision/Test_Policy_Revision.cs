using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Policy_Revision : MonoBehaviour
{
    EntitlePolicy_Dungeon1 entitlePolicy_Dungeon1 = new EntitlePolicy_Dungeon1();
    EntitlePolicy_Dungeon2 entitlePolicy_Dungeon2 = new EntitlePolicy_Dungeon2();
    EntitlePolicy_Dungeon3 entitlePolicy_Dungeon3 = new EntitlePolicy_Dungeon3();

    void Start()
    {
        Test();
    }

    void Test()
    {
        Debug.Log(entitlePolicy_Dungeon1.ComplyWithAll(Common.inst.member1));
        Debug.Log(entitlePolicy_Dungeon2.ComplyWithAll(Common.inst.member1));
        Debug.Log(entitlePolicy_Dungeon3.ComplyWithAll(Common.inst.member1));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Policy_Anti : MonoBehaviour
{
    void Start()
    {
        Debug.Log(IsEntitled_Dungeon1(Common.inst.member1));
        Debug.Log(IsEntitled_Dungeon2(Common.inst.member1));
        Debug.Log(IsEntitled_Dungeon3(Common.inst.member1));
    }

    bool IsEntitled_Dungeon1(Member member)
    {
        if (member.level <= 15) return false;
        if (member.attackPower_Magic + member.attackPower_Magic <= 100) return false;
        return true;
    }

    bool IsEntitled_Dungeon2(Member member)
    {
        if (member.level <= 15) return false;
        if (member.attackPower_Magic + member.attackPower_Magic <= 100) return false;
        if (member.hp <= 50) return false;
        if (member.mp <= 50) return false;
        return true;
    }

    bool IsEntitled_Dungeon3(Member member)
    {
        if (member.agility <= 10) return false;
        return true;
    }
}

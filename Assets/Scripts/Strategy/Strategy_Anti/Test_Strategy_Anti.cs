using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Strategy_Anti : MonoBehaviour
{
    string name = "";
    int costMP = 1;
    int atk = 1;
    int costTP = 1;    //テクニカルポイントが追加された。特に意味はない。

    void Start()
    {
        Test();
    }

    void Test()
    {
        MagicAttack(MagicType.fire, Common.inst.member1);
        Debug.Log($" {name} {costMP} {atk}");

        MagicAttack(MagicType.shiden, Common.inst.member2);
        Debug.Log($" {name} {costMP} {atk}");
    }


    void MagicAttack(MagicType magictype, Member member)
    {
        switch (magictype)
        {
            case MagicType.fire:
                name = "ファイア";
                costMP = 2;
                atk = 20 + (int)(member.level * 0.5);
                costTP = 0;
                break;

            case MagicType.shiden:
                name = "紫電";
                costMP = 5 + (int)(member.level * 0.2);
                atk = 50 + (int)(member.level * 1.5);
                costTP = 5;
                break;

            case MagicType.hellFire:
                name = "地獄の業火";
                costMP = 16;
                atk = 200 + (int)(member.attackPower_Magic * 0.5 + member.vitality * 2);
                costTP = 20 + (int)(member.level * 0.4);
                break;

            default:
                throw new System.Exception();
        }
    }
    //デメリット
    //条件分岐があり、魔法が追加されるたびに MagicAttack()関数 が膨れていく。
}
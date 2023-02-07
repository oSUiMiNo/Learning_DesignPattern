using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_SingleChoise_Pro : MonoBehaviour
{
    string name = "";
    int costMP = 1;
    int atk = 1;

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

        MagicAttack(MagicType.hellFire, Common.inst.member2);
        Debug.Log($" {name} {costMP} {atk}");
    }

    //単一責任選択の原則(Single Choise Principle)に基づいて、
    //1つの関数だけが選択肢の全てを把握している状態にした。

    //バリデーションを書いたので
    //fire か shiden 以外の魔法渡された場合、叱られて処理が止まる。

    //しかし、まだデメリットがある。
    //ストラテジーパターンに続く。

    void MagicAttack(MagicType magictype, Member member)
    {
        switch (magictype)
        {
            case MagicType.fire:
                name = "ファイア";
                costMP = 2;
                atk = 20 + (int)(member.level * 0.5);
                break;

            case MagicType.shiden:
                name = "紫電";
                costMP = 5 + (int)(member.level * 0.2);
                atk = 50 + (int)(member.level * 1.5);
                break;

            default:
                throw new System.Exception("例外発生");
        }
    }
}
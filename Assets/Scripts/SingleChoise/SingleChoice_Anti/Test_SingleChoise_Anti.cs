using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_SingleChoise_Anti : MonoBehaviour
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
        name = MagicName(MagicType.fire);
        costMP = CostMagicPoint(MagicType.fire, Common.inst.member1);
        atk = AttackPower(MagicType.fire, Common.inst.member1);
        Debug.Log($" {name} {costMP} {atk}");

        name = MagicName(MagicType.shiden);
        costMP = CostMagicPoint(MagicType.shiden, Common.inst.member2);
        atk = AttackPower(MagicType.shiden, Common.inst.member2);
        Debug.Log($" {name} {costMP} {atk}");
    }

    //各計算ロジック関数ごとにを分けている。

    //デメリット1
    //例えば、新しい魔法「地獄の業火」が追加された場合に、以下の関数全てにロジックを追加しなければならない。

    //デメリット2
    //例えば新仕様でMPと似たTPというポイントを実装することになった場合に、
    //他の人が CostMagicPoint()に似せて CostTechnicalPoint() を作るかもしれない。
    //その人は「地獄の業火」が追加されたことを知らず、CostTechnicalPoint() に地獄の業火のロジックを実装していなかった。

    //デメリット3
    //条件分岐に存在しない magictype が渡された場合でも何も言われないのでおかしさに気づけない。

    string MagicName(MagicType magictype)
    {
        string name = "";

        switch(magictype)
        {
            case MagicType.fire:
                name = "ファイア";
                break;
            case MagicType.shiden:
                name = "紫電";
                break;
        }

        return name;
    }

    int CostMagicPoint(MagicType magictype, Member member)
    {
        int costMp = 0;

        switch (magictype)
        {
            case MagicType.fire:
                costMp = 2;
                break;
            case MagicType.shiden:
                costMp = 5 + (int)(member.level * 0.2);
                break;
        }

        return costMp;
    }

    int AttackPower(MagicType magictype, Member member)
    {
        int atk = 0;

        switch (magictype)
        {
            case MagicType.fire:
                atk = 20 + (int)(member.level * 0.5);
                break;
            case MagicType.shiden:
                atk = 50 + (int)(member.level * 1.5);
                break;
        }

        return atk;
    }
}

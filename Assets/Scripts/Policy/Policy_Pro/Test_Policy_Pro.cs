using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Policy_Pro : MonoBehaviour
{
    EntitlePolicy entitlePolicy_Dungeon1 = new EntitlePolicy();
    EntitlePolicy entitlePolicy_Dungeon2 = new EntitlePolicy();
    EntitlePolicy entitlePolicy_Dungeon3 = new EntitlePolicy();

    void Start()
    {
        entitlePolicy_Dungeon1.Add(new LevelRule());
        entitlePolicy_Dungeon1.Add(new AttackPowerRule());

        entitlePolicy_Dungeon2.Add(new LevelRule());
        entitlePolicy_Dungeon2.Add(new AttackPowerRule());
        entitlePolicy_Dungeon2.Add(new HPRule());
        entitlePolicy_Dungeon2.Add(new MPRule());

        entitlePolicy_Dungeon3.Add(new AgilityRule());

        //このスクリプトはポリシーパターンを試す専用だから問題無いが、
        //実際は他のロジックなども書かれる可能性があり、その場合、
        //↑ この、ポリシーを作成する周辺無関係なロジックを差し込まれかねない。
        //Test_Policy_Revision では、各ポリシーを丁寧にクラス化して使いやすくした。

        Test();
    }


    void Test()
    {
        Debug.Log(entitlePolicy_Dungeon1.ComplyWithAll(Common.inst.member1));
        Debug.Log(entitlePolicy_Dungeon2.ComplyWithAll(Common.inst.member1));
        Debug.Log(entitlePolicy_Dungeon3.ComplyWithAll(Common.inst.member1));
    }
}

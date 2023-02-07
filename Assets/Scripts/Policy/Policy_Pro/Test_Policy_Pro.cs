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

        //���̃X�N���v�g�̓|���V�[�p�^�[����������p�������薳�����A
        //���ۂ͑��̃��W�b�N�Ȃǂ��������\��������A���̏ꍇ�A
        //�� ���́A�|���V�[���쐬������Ӗ��֌W�ȃ��W�b�N���������܂ꂩ�˂Ȃ��B
        //Test_Policy_Revision �ł́A�e�|���V�[�𒚔J�ɃN���X�����Ďg���₷�������B

        Test();
    }


    void Test()
    {
        Debug.Log(entitlePolicy_Dungeon1.ComplyWithAll(Common.inst.member1));
        Debug.Log(entitlePolicy_Dungeon2.ComplyWithAll(Common.inst.member1));
        Debug.Log(entitlePolicy_Dungeon3.ComplyWithAll(Common.inst.member1));
    }
}

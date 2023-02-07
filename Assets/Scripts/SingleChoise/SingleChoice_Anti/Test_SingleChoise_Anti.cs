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

    //�e�v�Z���W�b�N�֐����Ƃɂ𕪂��Ă���B

    //�f�����b�g1
    //�Ⴆ�΁A�V�������@�u�n���̋Ɖ΁v���ǉ����ꂽ�ꍇ�ɁA�ȉ��̊֐��S�ĂɃ��W�b�N��ǉ����Ȃ���΂Ȃ�Ȃ��B

    //�f�����b�g2
    //�Ⴆ�ΐV�d�l��MP�Ǝ���TP�Ƃ����|�C���g���������邱�ƂɂȂ����ꍇ�ɁA
    //���̐l�� CostMagicPoint()�Ɏ����� CostTechnicalPoint() ����邩������Ȃ��B
    //���̐l�́u�n���̋Ɖ΁v���ǉ����ꂽ���Ƃ�m�炸�ACostTechnicalPoint() �ɒn���̋Ɖ΂̃��W�b�N���������Ă��Ȃ������B

    //�f�����b�g3
    //��������ɑ��݂��Ȃ� magictype ���n���ꂽ�ꍇ�ł����������Ȃ��̂ł��������ɋC�Â��Ȃ��B

    string MagicName(MagicType magictype)
    {
        string name = "";

        switch(magictype)
        {
            case MagicType.fire:
                name = "�t�@�C�A";
                break;
            case MagicType.shiden:
                name = "���d";
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

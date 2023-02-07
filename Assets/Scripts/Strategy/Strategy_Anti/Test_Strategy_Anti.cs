using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Strategy_Anti : MonoBehaviour
{
    string name = "";
    int costMP = 1;
    int atk = 1;
    int costTP = 1;    //�e�N�j�J���|�C���g���ǉ����ꂽ�B���ɈӖ��͂Ȃ��B

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
                name = "�t�@�C�A";
                costMP = 2;
                atk = 20 + (int)(member.level * 0.5);
                costTP = 0;
                break;

            case MagicType.shiden:
                name = "���d";
                costMP = 5 + (int)(member.level * 0.2);
                atk = 50 + (int)(member.level * 1.5);
                costTP = 5;
                break;

            case MagicType.hellFire:
                name = "�n���̋Ɖ�";
                costMP = 16;
                atk = 200 + (int)(member.attackPower_Magic * 0.5 + member.vitality * 2);
                costTP = 20 + (int)(member.level * 0.4);
                break;

            default:
                throw new System.Exception();
        }
    }
    //�f�����b�g
    //�������򂪂���A���@���ǉ�����邽�т� MagicAttack()�֐� ���c��Ă����B
}
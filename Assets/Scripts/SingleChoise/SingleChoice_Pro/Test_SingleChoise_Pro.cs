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

    //�P��ӔC�I���̌���(Single Choise Principle)�Ɋ�Â��āA
    //1�̊֐��������I�����̑S�Ă�c�����Ă����Ԃɂ����B

    //�o���f�[�V�������������̂�
    //fire �� shiden �ȊO�̖��@�n���ꂽ�ꍇ�A�����ď������~�܂�B

    //�������A�܂��f�����b�g������B
    //�X�g���e�W�[�p�^�[���ɑ����B

    void MagicAttack(MagicType magictype, Member member)
    {
        switch (magictype)
        {
            case MagicType.fire:
                name = "�t�@�C�A";
                costMP = 2;
                atk = 20 + (int)(member.level * 0.5);
                break;

            case MagicType.shiden:
                name = "���d";
                costMP = 5 + (int)(member.level * 0.2);
                atk = 50 + (int)(member.level * 1.5);
                break;

            default:
                throw new System.Exception("��O����");
        }
    }
}
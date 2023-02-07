using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Strategy_Revision : MonoBehaviour
{
    string name = "";
    MagicPoint costMP = MagicPoint.initial;
    AttackPower atk = AttackPower.initial;
    TechnicalPoint costTP = TechnicalPoint.initial;
    //����3�̃t�B�[���h�͑S�� int�^ �������̂ŁA�~�X�ŕςȒl���������˂Ȃ����߁A
    //�l�I�u�V�F�N�g�������B�����������͍\���̂ƃN���X�ǂ����g���̂������񂾁H


    Dictionary<MagicType, Magic_Revision> magics = new Dictionary<MagicType, Magic_Revision>();

    void Start()
    {
        magics.Add(MagicType.fire, new Fire_Revision());
        magics.Add(MagicType.shiden, new Shiden_Revision());
        magics.Add(MagicType.hellFire, new HellFire_Revision());

        Test();
    }

    void Test()
    {
        MagicAttack(MagicType.fire, Common.inst.member1);
        Debug.Log($" {name} {costMP.value} {atk.value}");

        MagicAttack(MagicType.shiden, Common.inst.member2);
        Debug.Log($" {name} {costMP.value} {atk.value}");
    }

    void MagicAttack(MagicType magicType, Member member)
    {
        Magic_Revision usemagic = magics[magicType];

        usemagic.SpecifyMember(member);
        name = usemagic.Name();
        costMP = usemagic.CostMP();
        atk = usemagic.Atk();
        costTP = usemagic.CostTP();
    }
}

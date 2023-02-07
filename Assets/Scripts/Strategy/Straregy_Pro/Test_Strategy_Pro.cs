using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Strategy_Pro : MonoBehaviour
{
    string name = "";
    int costMP = 1;
    int atk = 1;
    int costTP = 1;    //�e�N�j�J���|�C���g���ǉ����ꂽ�B���ɈӖ��͂Ȃ��B

    Dictionary<MagicType, Magic> magics = new Dictionary<MagicType, Magic>();
    //�S���@�N���X�� Magic() �C���^�[�t�F�C�X�Œ��ۉ��������Ƃɂ���āA
    //���������ɑS�����[�ł���̂��傫�ȃ|�C���g�B

    //�����Ŏ����ɂ܂Ƃ߂邱�Ƃ������ړI�ł���΁Aobject�^ �Ƃ��Ď��[���邱�Ƃ��ł����B

    void Start()
    {
        magics.Add(MagicType.fire, new Fire());
        magics.Add(MagicType.shiden, new Shiden());
        magics.Add(MagicType.hellFire, new HellFire());

        Test();
    }

    void Test()
    {
        MagicAttack(MagicType.fire, Common.inst.member1);
        Debug.Log($" {name} {costMP} {atk}");

        MagicAttack(MagicType.shiden, Common.inst.member2);
        Debug.Log($" {name} {costMP} {atk}");
    }

    //���������ꂾ�Ƃ����Ō^�ϊ��p�̏�����������Ă��܂��̂ŁA�C���^�[�t�F�C�X�ɂ����B
    //�� ����Ɋւ��Ă� Test_Interface_Pro�N���X, Test_Interface_Anti�N���X ���Q��

    //����ɁA�����̃L�[�ɂ���Ăǂ̖��@�����f���Ă����̂ŏ������򂪕K�v�Ȃ��Ȃ����B
    void MagicAttack(MagicType magicType, Member member)
    {
        Magic usemagic = magics[magicType];
        
        usemagic.SpecifyMember(member);
        name = usemagic.Name();
        costMP = usemagic.CostMP();
        atk = usemagic.Atk();
        costTP = usemagic.CostTP();
    }
    //�u�n���̋Ɖ΁v�̌��̂悤�ɖ��@���ǉ����ꂽ�ۂ́A
    //���@�̃��W�b�N���܂Ƃ߂��N���X�����A�����ɒǉ����邾���B
    //�Ȃ̂ŁA����܂胍�W�b�N���c�ꂸ�ɍςށB
    
    //�u�e�N�j�J���|�C���g�v�̌��̂悤�ɖ��@�̎d�l���ǉ����ꂽ�ۂ́A
    //�܂��C���^�[�t�F�C�X�Ɋ֐���ǉ�����B
    //����ƁA���@���W�b�N�ɐV�d�l��ǉ����Y�ꂽ�ꍇ�ɃG���[�Œm�点�Ă����B
}

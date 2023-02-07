using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Magic_Revision
{
    void SpecifyMember(Member mamber);
    string Name();
    MagicPoint CostMP();
    AttackPower Atk();
    TechnicalPoint CostTP();

    //����3�̊֐��̖߂�l�͑S�� int�^ �������̂ŁA�~�X�ŕςȒl���������˂Ȃ����߁A
    //�l�I�u�V�F�N�g�������B�����������͍\���̂ƃN���X�ǂ����g���̂������񂾁H
}

public class Fire_Revision : Magic_Revision
{
    Member member;

    public void SpecifyMember(Member mamber)
    {
        this.member = mamber;
    }

    public string Name()
    {
        return "�t�@�C�A";
    }

    public MagicPoint CostMP()
    {
        int value = 2;
        return new MagicPoint(value);
    }

    public AttackPower Atk()
    {
        int value = 20 + (int)(member.level * 0.5);
        return new AttackPower(value);
    }

    public TechnicalPoint CostTP()
    {
        int value = 0;
        return new TechnicalPoint(value);
    }
}

public class Shiden_Revision : Magic_Revision
{
    Member member;

    public void SpecifyMember(Member mamber)
    {
        this.member = mamber;
    }

    public string Name()
    {
        return "���d";
    }

    public MagicPoint CostMP()
    {
        int value = 5 + (int)(member.level * 0.2);
        return new MagicPoint(value);
    }

    public AttackPower Atk()
    {
        int value = 50 + (int)(member.level * 1.5);
        return new AttackPower(value);
    }

    public TechnicalPoint CostTP()
    {
        int value = 5;
        return new TechnicalPoint(value);
    }
}

public class HellFire_Revision : Magic_Revision
{
    Member member;

    public void SpecifyMember(Member mamber)
    {
        this.member = mamber;
    }

    public string Name()
    {
        return "�n���̋Ɖ�";
    }

    public MagicPoint CostMP()
    {
        int value = 16;
        return new MagicPoint(value);
    }

    public AttackPower Atk()
    {
        int value = 200 + (int)(member.attackPower_Magic * 0.5 + member.vitality * 2); ;
        return new AttackPower(value);
    }

    public TechnicalPoint CostTP()
    {
        int value = 20 + (int)(member.level * 0.4);
        return new TechnicalPoint(value);
    }
}


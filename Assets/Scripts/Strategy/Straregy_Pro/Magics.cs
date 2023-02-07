using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Magic
{
    void SpecifyMember(Member mamber);
    string Name();
    int CostMP();
    int Atk();
    int CostTP();
}

public class Fire : Magic
{
    Member member;

    public void SpecifyMember(Member mamber)
    {
        this.member = mamber;
    }

    public string Name()
    {
        return "ファイア";
    }

    public int CostMP()
    {
        return 2;
    }

    public int Atk()
    {
        return 20 + (int)(member.level * 0.5);
    }

    public int CostTP()
    {
        return 0;
    }
}

public class Shiden : Magic
{
    Member member;

    public void SpecifyMember(Member mamber)
    {
        this.member = mamber;
    }

    public string Name()
    {
        return "紫電";
    }

    public int CostMP()
    {
        return 5 + (int)(member.level * 0.2);
    }

    public int Atk()
    {
        return 50 + (int)(member.level * 1.5);
    }

    public int CostTP()
    {
        return 5;
    }
}

public class HellFire : Magic
{
    Member member;

    public void SpecifyMember(Member mamber)
    {
        this.member = mamber;
    }

    public string Name()
    {
        return "地獄の業火";
    }

    public int CostMP()
    {
        return 16;
    }

    public int Atk()
    {
        return 200 + (int)(member.attackPower_Magic * 0.5 + member.vitality * 2);
    }

    public int CostTP()
    {
        return 20 + (int)(member.level * 0.4);
    }
}

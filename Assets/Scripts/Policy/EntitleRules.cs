using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface EntitleRule
{
    bool OK(Member member);
}

public class LevelRule : EntitleRule
{
    public bool OK(Member member)
    {
        return (member.level >= 15);
    }
}

public class MPRule : EntitleRule
{
    public bool OK(Member member)
    {
        return (member.mp >= 50);
    }
}

public class HPRule : EntitleRule
{
    public bool OK(Member member)
    {
        return (member.hp >= 50);
    }
}

public class AgilityRule : EntitleRule
{
    public bool OK(Member member)
    {
        return (member.agility >= 10);
    }
}

public class AttackPowerRule : EntitleRule
{
    public bool OK(Member member)
    {
        return (member.attackPower_Magic + member.attackPower_Magic >= 100);
    }
}

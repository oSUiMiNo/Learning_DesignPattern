using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitlePolicy_Dungeon1 : EntitlePolicy
{
    public EntitlePolicy_Dungeon1()
    {
        Add(new LevelRule());
        Add(new AttackPowerRule());
    }
}

public class EntitlePolicy_Dungeon2 : EntitlePolicy
{
    public EntitlePolicy_Dungeon2()
    {
        Add(new LevelRule());
        Add(new AttackPowerRule());
        Add(new HPRule());
        Add(new MPRule());
    }
}

public class EntitlePolicy_Dungeon3 : EntitlePolicy
{
    public EntitlePolicy_Dungeon3()
    {
        Add(new AgilityRule());
    }
}
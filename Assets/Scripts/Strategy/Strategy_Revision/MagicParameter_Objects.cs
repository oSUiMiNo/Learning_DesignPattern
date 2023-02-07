using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPoint
{
    public int value;
    public static MagicPoint initial = new MagicPoint(1);

    public MagicPoint(int value)
    {
        if (value < 0)
            throw new System.Exception("—áŠO”­¶");

        this.value = value;
    }
}

public class AttackPower
{
    public int value;
    public static AttackPower initial = new AttackPower(1);

    public AttackPower(int value)
    {
        if (value < 0)
            throw new System.Exception("—áŠO”­¶");

        this.value = value;
    }
}

public class TechnicalPoint
{
    public int value;
    public static TechnicalPoint initial = new TechnicalPoint(1);

    public TechnicalPoint(int value)
    {
        if (value < 0)
            throw new System.Exception("—áŠO”­¶");

        this.value = value;
    }
}

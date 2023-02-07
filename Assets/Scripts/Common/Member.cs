using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Member : MonoBehaviour
{
    public string name;
    public int hp;
    public int mp;
    public int tp;
    public int level;
    public float agility;
    public float vitality;
    public float attackPower_Physical;
    public float attackPower_Magic;
    public float defencePower;

    private void Start()
    {
        if (name == "") name = this.gameObject.name;
        if (hp == 0) hp = 100;
        if (mp == 0) mp = 100;
        if (mp == 0) tp = 100;
        if (level == 0) level = 1;
        if (agility == 0) agility = 1;
        if (vitality == 0) vitality = 1;
        if (attackPower_Physical == 0) attackPower_Physical = 1;
        if (attackPower_Magic == 0) attackPower_Magic = 1;
        if (defencePower == 0) defencePower = 1;
    }
}

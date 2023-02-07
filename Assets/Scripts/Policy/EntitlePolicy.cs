using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitlePolicy
{
    public List<EntitleRule> rules = new List<EntitleRule>();

    public void Add(EntitleRule rule)
    {
        rules.Add(rule);
    }

    public bool ComplyWithAll(Member member)
    {
        foreach(var rule in rules)
        {
            if(!rule.OK(member)) return false;
        }

        return true;
    }
}

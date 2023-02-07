using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_Pro : IShape
{
    private readonly float radius = 10; 

    public override float Area()
    {
        return radius * radius * Mathf.PI;
    }
}

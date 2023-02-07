using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle_Pro : IShape
{
    private readonly float height = 10;
    private readonly float width = 10;
    
    public override float Area()
    {
        return height * width;
    }
}

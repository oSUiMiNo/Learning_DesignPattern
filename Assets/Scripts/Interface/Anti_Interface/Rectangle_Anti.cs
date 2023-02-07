using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle_Anti : MonoBehaviour
{
    private readonly float height = 10;
    private readonly float width = 10;

    public float Area()
    {
        return height * width;
    }
}

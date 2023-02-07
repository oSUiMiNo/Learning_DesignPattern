using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_Anti : MonoBehaviour
{
    private readonly float radius = 10;

    public float Area()
    {
        return radius * radius * Mathf.PI;
    }
}

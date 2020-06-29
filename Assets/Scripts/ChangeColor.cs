using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ChangeColor
{
    public static void ColorChange(GameObject obj, Color color)
    {
        obj.GetComponent<Renderer>().material.color = color;
    }
    /// <summary>
    /// Random Color
    /// </summary>
     public static void ColorChange(GameObject obj)
    {
        
        var color = new Color(Random.value, Random.value, Random.value);
        obj.GetComponent<Renderer>().material.color = color;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Experimental.Rendering;

public class LinqExpressions : MonoBehaviour
{
    public int[] grades = {12,54,85,64,20,100,45,87,96,35,42,01,25,85,4,12,69,48,25,12,84,75,96,32,12,05,85,65,15,74 };

    // Start is called before the first frame update
    void Start()
    {
        var c = grades.Where(g => g > 69);
        foreach(int n in c)
        {
            Debug.Log(n);
        }
    }

}

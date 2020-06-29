using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main.onSpaceBar += ChangePos;
    }

    public void ChangePos()
    {
        this.transform.position = new Vector3(5, 2, 0);
    }
}

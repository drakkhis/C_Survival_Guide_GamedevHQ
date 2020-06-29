using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Name { get; set; }

    public float Speed { get; } = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Speed);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}

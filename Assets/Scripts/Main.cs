using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public delegate void OnSpaceBar();
    public static event OnSpaceBar onSpaceBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onSpaceBar != null)
                onSpaceBar();
        }
    }
}

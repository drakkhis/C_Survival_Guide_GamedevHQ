using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int myAge = 26;
    private int _legalAgeToDrive = 16;

    // Start is called before the first frame update
    void Start()
    {
         if (myAge >= _legalAgeToDrive)
        {
            Debug.Log("you can drive");
        }
        else
        {
            Debug.Log("You can not drive");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

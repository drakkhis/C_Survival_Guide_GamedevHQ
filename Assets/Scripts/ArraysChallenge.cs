using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysChallenge : MonoBehaviour
{
    [SerializeField]
    private string[] _names;
    [SerializeField]
    private int[] _ages;
    [SerializeField]
    private string[] _cars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Name : " + _names[4] + " Age: " + _ages[4] + " Car: " + _cars[4]);
        }
    }
}

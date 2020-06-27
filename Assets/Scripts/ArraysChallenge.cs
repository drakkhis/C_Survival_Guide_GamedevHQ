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
            int i = Random.Range(0, 5);
            Debug.Log("Name : " + _names[i] + " Age: " + _ages[i] + " Car: " + _cars[i]);
        }
    }
}

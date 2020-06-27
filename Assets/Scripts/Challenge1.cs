using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge1 : MonoBehaviour
{
    public float Quiz1, Quiz2, Quiz3, Quiz4, Quiz5;

    // Start is called before the first frame update
    void Start()
    {
        Quiz1 = Random.Range(0f, 100f);
        Quiz2 = Random.Range(0f, 100f);
        Quiz3 = Random.Range(0f, 100f);
        Quiz4 = Random.Range(0f, 100f);
        Quiz5 = Random.Range(0f, 100f);
        float average = (Quiz1 + Quiz2 + Quiz3 + Quiz4 + Quiz5) / 5;
        if (average >= 90f)
        {
            Debug.Log("You got an A");
        }
        else if (average >= 80f && average < 90f)
        {
            Debug.Log("You got a B");
        }
        else if (average >= 70f && average < 80f)
        {
            Debug.Log("you got a C");
        }
        else
        {
            Debug.Log("You Failed");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

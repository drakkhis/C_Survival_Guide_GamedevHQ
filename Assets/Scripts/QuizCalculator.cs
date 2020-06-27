using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float Quiz1, Quiz2, Quiz3, Quiz4, Quiz5;
    // Start is called before the first frame update
    void Start()
    {
        Quiz1 = Random.Range(0, 100f);
        Quiz2 = Random.Range(0, 100f);
        Quiz3 = Random.Range(0, 100f);
        Quiz4 = Random.Range(0, 100f);
        Quiz5 = Random.Range(0, 100f);
        float quizTotal = Quiz1 + Quiz2 + Quiz3 + Quiz4 + Quiz5;
        float QuizAverage = quizTotal / 5;
        QuizAverage = Mathf.Round(QuizAverage * 100) / 100;

        Debug.Log("The Average of all the Quizes is " + QuizAverage);
    }

}

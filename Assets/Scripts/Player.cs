using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private int _age;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private int _health;
    [SerializeField]
    private int _score;
    [SerializeField]
    private bool _keysCollected;
    [SerializeField]
    private int _ammoCount;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is " + _name + ", I am " + _age + " years old");
        Debug.Log("I have " + _health + " remaining.");
        Debug.Log("I can move at a speed of " + _speed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

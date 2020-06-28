using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    [SerializeField]
    private Customer[] _customers;
    // Start is called before the first frame update
    void Start()
    {
        _customers[0] = new Customer("Jack", "Bean", 23, "male", "climber");
        _customers[1] = new Customer("Jill", "Bean", 21, "female", "catcher");
        _customers[2] = new Customer("Bean", "Stock", 52, "male", "plant");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

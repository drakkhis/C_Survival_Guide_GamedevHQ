using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge5 : MonoBehaviour
{
    [SerializeField]
    private int _speed;
    [SerializeField]
    private int _maxSpeed;
    [SerializeField]
    private int _minSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _speed += 10;
            if (_speed >= _maxSpeed)
            {
                Debug.Log("you need to slow down");
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (_speed > _minSpeed)
            {
                _speed -= 10;
                if (_speed == _minSpeed)
                {
                    Debug.Log("you need to speed up");
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsMethodsChallenge : MonoBehaviour
{
    [SerializeField]
    private int _healthMax;
    [SerializeField]
    private int _health;
    // Start is called before the first frame update
    void Start()
    {
        _health = _healthMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_health > 0)
                Damage(Random.Range(5, 11));
            else
                Debug.Log("Player Is Dead");
            Debug.Log("Player has " + _health + " health remaining");
        }
    }

    private void Damage(int amount)
    {
        _health -= amount;
        Debug.Log("Player has taken " + amount + " damage");
        if (_health < 1)
        {
            _health = 0;
            Debug.Log("Player Is Dead");
        }
            
    }
}

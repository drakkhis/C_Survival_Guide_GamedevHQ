using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    public float _bill;
    public float _tip;
    private float _total;

    // Start is called before the first frame update
    void Start()
    {
        float _tipTemp = _bill * (_tip / 100);
        _total = _bill + _tipTemp;
        Debug.Log("Your bill is " +_bill + " and your tip percentage is " + _tip + " you owe " + _total);
        
    }

}

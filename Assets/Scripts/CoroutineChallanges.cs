using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineChallanges : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ColorShift());
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    IEnumerator ColorShift()
    {
        while(true)
        {
            yield return new WaitForSeconds(3.0f);
            transform.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

    }
}

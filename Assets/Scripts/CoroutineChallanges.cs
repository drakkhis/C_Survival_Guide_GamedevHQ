using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineChallanges : MonoBehaviour
{
    private bool isVisable = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && isVisable)
        {
            StartCoroutine(Vanish());
        }
    }

    IEnumerator Vanish()
    {
        isVisable = false;
        transform.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(5.0f);
        transform.GetComponent<MeshRenderer>().enabled = true;
        isVisable = true;
    }
}

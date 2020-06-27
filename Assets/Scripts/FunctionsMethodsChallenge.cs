using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsMethodsChallenge : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeCubeColor(_cube, Color.red);
        }
    }

    private void ChangeCubeColor(GameObject obj, Color shade)
    {
        obj.GetComponent<MeshRenderer>().material.color = shade;
    }
}

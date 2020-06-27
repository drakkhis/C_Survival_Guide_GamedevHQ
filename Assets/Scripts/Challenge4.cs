using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge4 : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;
    private MeshRenderer _cubeRenderer;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        _cubeRenderer = _cube.GetComponent<MeshRenderer>();
        if (_cubeRenderer == null)
        {
            Debug.Log("No renderer Found");
        }
        else
        {
            _cubeRenderer.material.SetColor("_Color",Color.red);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
            if (score > 50)
            {
                _cubeRenderer.material.SetColor("_Color", Color.green);
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsMethodsChallenge : MonoBehaviour
{
    [SerializeField]
    private Vector3[] _positions;
    [SerializeField]
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetPosition(_player, _positions[RandomIndex(_positions)]);
        }

    }

    private void SetPosition(GameObject obj, Vector3 pos)
    {
        obj.transform.position = pos;
    }

    private int RandomIndex(Vector3[] posArray)
    {
        return Random.Range(0, posArray.Length);
    }
}

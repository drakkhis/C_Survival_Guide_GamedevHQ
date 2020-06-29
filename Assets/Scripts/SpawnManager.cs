using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _prefabList = new List<GameObject>();
    [SerializeField]
    private List<GameObject> _spawnedList = new List<GameObject>();
    private int _spawnCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _spawnCount < 10)
        {
            Spawn(_prefabList[Random.Range(0, _prefabList.Count)]);
            _spawnCount = _spawnedList.Count;
        }
        if (_spawnedList.Count == 10)
        {
            GreenChange(_spawnedList);
            _spawnedList.Clear();
        }

    }

    private void Spawn(GameObject obj)
    {
        Vector3 pos = new Vector3(Random.Range(-10f,10f),Random.Range(-10f,10f),0);
        var prefabSpawn = _prefabList[Random.Range(0, _prefabList.Count)];
        GameObject go = Instantiate(prefabSpawn, pos, Quaternion.identity) as GameObject;
        _spawnedList.Add(go);
    }

    private void GreenChange(List<GameObject> list)
    {
        foreach(GameObject obj in list)
        {
            Renderer rend = obj.GetComponent<MeshRenderer>();
            rend.material.color = Color.green;
        }
    }
}

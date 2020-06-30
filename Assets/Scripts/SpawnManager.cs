using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnManager : MonoBehaviour
{
    public Wave[] waves;
    public int curWave = 1;
    public List<GameObject> curEnemis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(StartWaveRoutine());
        }
    }


    IEnumerator StartWaveRoutine()
    {
        while(curWave < waves.Length)
        {
            foreach(var wave in waves)
            {
                foreach (var enemy in wave.enemies)
                {
                    Vector3 loc = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f);
                    curEnemis.Add(Instantiate(enemy, loc, Quaternion.identity));
                }
                yield return new WaitForSeconds(5.0f);
                curEnemis.ForEach(i => Destroy(i));
                curWave++;
            }
            
        }
    }
}

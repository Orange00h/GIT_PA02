using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] StufftoSpawn;
    int randomSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnStuff", 0, 1);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnStuff()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-1.5f, 1.5f), 0, 0);
        randomSpawn = Random.Range(0, StufftoSpawn.Length);

        Instantiate(StufftoSpawn[randomSpawn], spawnPos, Quaternion.identity);


    }
}

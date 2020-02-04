using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnScript : MonoBehaviour
{
    public GameObject[] Enemies;
    public float spawnTime = 3;
    public int i;
    public float spawnDelay = 10;
    public bool stopSpawning = false;
    public float distance = 1;
    void Start()
    {
        InvokeRepeating("SpawnWave", spawnTime, spawnDelay);
        
    }

    public void SpawnWave()
    {
        for (int i = 0; i < 10; i++)
        {
            //generates cube from prefabs folder at the set location aswell as creating space between them
            Instantiate(Enemies[Random.Range(0, 4)], new Vector3(transform.position.x, 0, i + distance - 16), Quaternion.identity);
            distance += 1;
            print(i + 1);
        }
        if (stopSpawning)
        {
            CancelInvoke("SpawnWave");
        }
    }
}

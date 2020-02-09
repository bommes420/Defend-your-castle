using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnScript : MonoBehaviour
{
    private Movescript moveScript;
    public GameObject[] Enemies;
    public float spawnTime = 3;
    public float spawnDelay = 20;
    public bool stopSpawning = false;

    public float distance = 2;
    public int waveCounter = 0;
    void Start()
    {
        InvokeRepeating("SpawnWave", spawnTime, spawnDelay);
    }

    public void SpawnWave()
    {
        waveCounter++;
        print(waveCounter);
        for (int i = 0; i < 10; i++)
        {
            //generates cube from prefabs folder at the set location aswell as creating space between them
            Instantiate(Enemies[0], new Vector3(transform.position.x, 0, i += 1) * distance, Quaternion.identity);
        }
        if(waveCounter > 4)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(Enemies[Random.Range(0,2)], new Vector3(transform.position.x, 0, i += 1) * distance, Quaternion.identity);
            }
        }
        if (stopSpawning)
        {
            CancelInvoke("SpawnWave");
        }
    }
}
//Instantiate(Enemies[Random.Range(0, 4)], new Vector3(transform.position.x, 0, Mathf.Round(Random.Range(-20,20))) * distance, Quaternion.identity);
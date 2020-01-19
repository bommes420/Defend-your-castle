using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] Enemies;
    public int WaveTimer;
    // Start is called before the first frame update
    public float distance = 1;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            //generates cube from prefabs folder at the set location aswell as creating space between them
            Instantiate(Enemies[Random.Range(0,4)], new Vector3(transform.position.x, 0, i + distance - 15), Quaternion.identity);
            distance += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

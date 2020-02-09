using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Movescript : MonoBehaviour
{
    public GameObject wall;
    public float wallHP = 100f;
    public float Tijd = 0f;
    public float speed = 1f;
    public float DamageHealth = 100f;
    public float DamageDelay = 1f;
    public float Health = 100f;
    public float HealthShow;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        HealthShow = Health;
        Tijd += 1 * Time.deltaTime;
        if(transform.position.x < 12)
        {
            //update position to a new vector3(x,y,z). the x variable determines the speed of the object
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if(transform.position.x >= 12)
        {
            GameObject w = GameObject.Find("Castle");
            CastleHealth castleHealth = w.GetComponent<CastleHealth>();
            castleHealth.currentwallHP -= 0.5f * Time.deltaTime;
            castleHealth.healthText.text = "Health: " + castleHealth.currentwallHP.ToString("0") + "%";
            if(castleHealth.currentwallHP <= 0)
            {
                castleHealth.healthText.text = "Game over.";
                GameObject s = GameObject.Find("Spawner");
                SpawnScript spawnScript = s.GetComponent<SpawnScript>();
                spawnScript.stopSpawning = true;
            }
        }

        if (Health <= 0)
        {
            //destroy gameobject attached to this script
            Destroy(this.gameObject);
        }
    }
    public void DoDamage()
    {
        //Function which requests the Health variable (requested in shootingscript)
        Health -= DamageHealth;
    }
}

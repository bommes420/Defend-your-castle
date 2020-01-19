using UnityEngine;
using UnityEngine.UI;

public class Movescript : MonoBehaviour
{
    public GameObject wall;
    public Text healthText;
    public int wallHP = 100;
    public float Tijd = 0f;
    public float speed = 1f;
    public float DamageHealth = 100f;
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
        
            wallHP--;
            
            healthText.text = "Health: " + wallHP.ToString() + "%";
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

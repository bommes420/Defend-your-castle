using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleHealth : MonoBehaviour
{
    public GameObject wall;
    public Text healthText;
    public float wallHP = 100;
    // Start is called before the first frame update
    void Start()
    {
        wallHP = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //print(wallHP);
    }

    void OnGUI()
    {
        if (transform.position.x > 12)
        {
            wallHP -= Time.deltaTime;
            GUI.Label(new Rect(100, 100, 375, 100), "Health " + (int)wallHP);

            if ((int)wallHP <= 0)
            {
                wallHP = 0;
            }
        }
    }

    void OnCollision(Collision col)
    {
        Debug.Log(col.transform.position);
    }
}

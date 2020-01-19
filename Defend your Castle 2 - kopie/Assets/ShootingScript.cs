using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingScript : MonoBehaviour
{
    Camera cam;
    
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        // if left mouse button is pressed
        if (Input.GetMouseButtonDown(0)) 
        { 
            //generate a ray on screen directed by the mouse position
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // hit.collider.gameObject.GetComponent<Movescript>().Health = hit.collider.gameObject.GetComponent<Movescript>().Health - 25;
                hit.collider.gameObject.GetComponent<Movescript>().DoDamage();
            }
        }
    }
}

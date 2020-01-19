using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    // Start is called before the first frame update
    float HealthScale = 2.901869f;
    float HealthScaleMAX = 2.901869f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //   HealthScale -= 0.1f * gameObject.GetComponentInParent<Movescript>().Health;
        HealthScale = (HealthScaleMAX * gameObject.GetComponentInParent<Movescript>().Health)/100;
        transform.localScale = new Vector3(HealthScale, 0.28539f, 0.26364f);
    }
}

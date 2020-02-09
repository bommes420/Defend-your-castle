using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleHealth : MonoBehaviour
{
    public GameObject wall;
    public Text healthText;
    public float startwallHP = 100f;
    public float currentwallHP = 0f;
    // Start is called before the first frame update
    void Start()
    {
        currentwallHP = startwallHP;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}

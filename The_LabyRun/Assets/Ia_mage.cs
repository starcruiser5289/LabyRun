using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ia_mage : MonoBehaviour
{
    
    // Start is called before the first frame update
    public float speed;
    public float stoppingdistance;
    public float retreatdistance;
    public Transform player; 
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

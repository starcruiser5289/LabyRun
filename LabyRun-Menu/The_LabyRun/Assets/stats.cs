using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    
    static int colo ;
    public int heal ; 
    
    // Start is called before the first frame update
    private void Start()
    {
        colo = 8;
        heal = 0;
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("clef"))
        {
            colo += 1;
            Debug.Log("chouf" + colo );
        }

        if (collision.CompareTag("potion"))
        {
            heal += 1;

        }

    }

     
}

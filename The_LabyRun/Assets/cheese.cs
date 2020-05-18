using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheese : MonoBehaviour
{
    public deplacement ramzy; 
    public bool jaja = false;

    public float cd = 0; 
    // Start is called before the first frame update
    void Start()
    {
        

    }
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        

        if (collision.CompareTag("Player"))
        {
            
            jaja = true; 

        }

    }
    // Update is called once per frame
    void Update()
    {
        if (jaja)
        {
            
            while (cd < 15000)
            {
                ramzy.vitesse = 10;
                cd += Time.deltaTime; 
            }

            ramzy.vitesse = 5;

        }
        
    }
}
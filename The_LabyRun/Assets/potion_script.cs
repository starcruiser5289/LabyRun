using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potion_script : MonoBehaviour
{
    public health_script life ;
    public AudioSource tit;

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        tit.Play();
        if (other.CompareTag("Player") && life.hp < 3)
        {
           
            life.hp += 1; tit.Play(); 
            
        }
        
    }

}

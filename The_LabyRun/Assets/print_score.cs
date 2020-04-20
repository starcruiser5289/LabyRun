using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;
public class print_score : MonoBehaviour
{
    public deplacement player;
    public Text canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas.text = Convert.ToString(player.score); 


    }
    

    // Update is called once per frame
    void Update()
    {
        int scr = player.score; 
        canvas.text = "Nombre de clés recupérées :" +scr +"\n " + "Nombre de clés restantes " + Convert.ToString(5-scr) ;
        
        
    }
}

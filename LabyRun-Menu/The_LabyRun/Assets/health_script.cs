using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;
public class health_script : MonoBehaviour
{
    public int hp;

    public int nb_coeurs;
    public Image[] coeurs;
    public Sprite full;
    public Sprite empty;
    public ia_entité monstre; 
    
    

    // Update is called once per frame
    void Update()
    {
       
        
        for (int j = 0; j < coeurs.Length; j++)
        {
            if (hp > nb_coeurs)
            {
                hp = nb_coeurs; 
            }
            if (j < hp)
            {
                coeurs[j].sprite = full; 
            }
            else
            {
                coeurs[j].sprite = empty; 
            }
            if (j < nb_coeurs)
            {
                coeurs[j].enabled = true;
            }
            else
            {
                coeurs[j].enabled = false ; 
            }
            
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    public deplacement joueur;
    public static void Jouerson()
    {
        GameObject son  = new GameObject("Son");
        AudioSource source = son.AddComponent<AudioSource>();
        
    }
}

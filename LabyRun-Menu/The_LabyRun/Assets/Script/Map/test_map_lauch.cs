using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test_map_lauch : MonoBehaviour
{
    public reading_construction read;
    public print_score score; 

    public Generation gen;

    
    private void Start()
    {
             gen.cells_init();
             read.Map_Constructor(gen.random_gen());
    }
    
    
    public void DestroyAllGameObjects()
    {
        GameObject[] GameObjects = (FindObjectsOfType<GameObject>() as GameObject[]);
 
        for (int i = 0; i < GameObjects.Length; i++)
        {
            Destroy(GameObjects[i]);
        }
    }
    
}

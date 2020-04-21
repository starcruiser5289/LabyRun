using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_map_lauch : MonoBehaviour
{
    public reading_construction read;

    public Generation gen;

    private void Start()
    {
        
            gen.cells_init();
            read.Map_Constructor(gen.random_gen());
        
    }

    



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_lvl2 : MonoBehaviour
{
    public reading_construction read;
    public print_score score; 

    public Generation gen;

    
    private void Start()
    {
        gen.cells_init();
        read.Map_Constructor(gen.random_gen());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_lauch : MonoBehaviour
{
    public reading_construction read;

    public Generation gen;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("q"))
        {
            gen.cells_init();
            read.Map_Constructor(gen.random_gen());      
        }



    }
}

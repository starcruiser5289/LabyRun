using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_map_lauch : MonoBehaviour
{
    public reading_construction read;
    public Generation gen;
    public test Test;


    private void Start()
    {
        Test = new test();
    }
    // Update is called once per frame
    void Update()
    {


        //this input is only used to test Generation.cs and reading_construction.cs 
        //creating a new random map
        //following commands will be used at the start of a new game
        if (Input.GetKey("q"))
        {
            gen.cells_init();
            read.Map_Constructor(gen.random_gen());      
        }
        if (Input.GetKeyDown("e"))
        {
            Test.Starting();
        }


    }
}

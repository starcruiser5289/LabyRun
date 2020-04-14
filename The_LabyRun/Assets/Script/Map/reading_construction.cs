using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reading_construction : MonoBehaviour
{
    //each individual object to instantiate
    public GameObject wall; 
    public GameObject lever;
    public GameObject obstacle;
    public GameObject spawn;
    public GameObject button;
    

    // this vector2 will change the scale of object like walls(not yet sure if usefull for now)
    public Vector2 scale;



    public void Map_Constructor(int[][] matrice)
    {
        /**this methode takes each individual int from a bit-map and activate
        other methods to create the map */

        int lon = matrice.Length;
        for (int y = 0; y < lon; y++)
        {
            for (int x = 0; x < lon; x++)
            {

                switch (matrice[y][x])
                {

                    case (1):
                        wall_gen(x, y);
                        break;
                    case (2):
                        lever_gen(x, y);
                        break;
                    case (3):
                        obstacle_gen(x, y);
                        break;
                    case (4):
                        spawn_gen(x, y);
                        break;
                    case (5):
                        button_gen(x, y);
                        break;
                    


                }

            }
        }

    }




    // these methods instantiate there respective objects on the map
    public void wall_gen(int x, int y) 
    {
        GameObject Wall = Instantiate(wall, new Vector3(x, y, 0),wall.transform.rotation) as GameObject;
        
        // here we can add more code 
        //to add scripts or other components 
        //onto each clone
    }



    public void lever_gen(int x, int y) 
    {
        GameObject Lever = Instantiate(lever, new Vector3(x, y, 0), wall.transform.rotation) as GameObject;
        // here we can add more code 
        //to add scripts or other components 
        //onto each clone
    }


    public void obstacle_gen(int x, int y)
    {
        GameObject Obstacle = Instantiate(obstacle, new Vector3(x, y, 0), wall.transform.rotation) as GameObject;
        // here we can add more code 
        //to add scripts or other components 
        //onto each clone
    }


    public void spawn_gen(int x, int y)
    {
        GameObject Spawn = Instantiate(spawn, new Vector3(x, y, 0), wall.transform.rotation) as GameObject;
        // here we can add more code 
        //to add scripts or other components 
        //onto each clone
    }


    public void button_gen(int x, int y)
    {
        GameObject Button = Instantiate(button, new Vector3(x, y, 0), wall.transform.rotation) as GameObject;
        // here we can add more code 
        //to add scripts or other components 
        //onto each clone
    }

}

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
    public GameObject clef;
    public GameObject potion;
    

    // this vector2 will change the scale of object like walls(not yet sure if usefull for now)
    public Vector2 scale;



    public void Map_Constructor(uint[][] matrice)
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
                        clef_gen(x, y);
                        break;
                    


                }

            }
        }

    }




    // these methods instantiate there respective objects on the map
    public void wall_gen(int x, int y) 
    {
        GameObject Wall = Instantiate(wall, new Vector3(x, y, 0),wall.transform.rotation) as GameObject;
        SpriteRenderer sprite= Wall.GetComponent<SpriteRenderer>();
        BoxCollider2D box = wall.GetComponent<BoxCollider2D>();
        box.enabled = true;
        sprite.enabled = true;
        
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
        SpriteRenderer sprite = Spawn.GetComponent<SpriteRenderer>();
        sprite.enabled = true;
        // here we can add more code 
        //to add scripts or other components 
        //onto each clone
    }
    public void potion_gen(int x, int y)
    {
        GameObject Potion = Instantiate(potion, new Vector3(x, y, 0), wall.transform.rotation) as GameObject;
        SpriteRenderer sprite = Potion.GetComponent<SpriteRenderer>();
        BoxCollider2D zz = potion.GetComponent<BoxCollider2D>();
        zz.enabled = true;
        sprite.enabled = true;
        
    }
    


    public void clef_gen(int x, int y)
    {
        GameObject Clef = Instantiate(clef, new Vector3(x, y, 0), wall.transform.rotation) as GameObject;
        SpriteRenderer sprite = Clef.GetComponent<SpriteRenderer>();
        BoxCollider2D clé = clef.GetComponent<BoxCollider2D>();
        clé.enabled = true;
        sprite.enabled = true;
        // here we can add more code 
        //to add scripts or other components 
        //onto each clone
    }

}

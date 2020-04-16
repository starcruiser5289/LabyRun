using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{

    private uint cellsize;
    private uint mazesize;

    List<int[][]> cells = new List<int[][]> { };





    public Generation(uint cellsize)
    {
        this.cellsize = cellsize;
        mazesize = (cellsize * 3) + 2;
    }





    //creates an empty maze with only exterieur walls 
    //to be used in maze creation methods
    public uint[][] Empty_map_generator()
    {
        uint[][] ext = new uint[mazesize][];
        for (int i = 0; i < mazesize; i++)
        {
            ext[i] = new uint[mazesize];
        }

        for (int x = 0; x < mazesize; x++)
        {
            for (int y = 0; y < mazesize; y++)
            {
                if (y == 0 || y == mazesize - 1 || x==0 || x==mazesize-1)
                {
                    ext[y][x] = 1;

                }
            }
        }
        return ext;
    }


    public uint[,] cell_layout()
    {
        uint[,] ext = new uint[3, 3];
        int len = cells.Count;
        Random rand = new 


        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                ext[y,x] = Random.
            }
        }



        return ext;
    }





    //
    public uint[][] random_gen() 
    {
        uint[][] ext = Empty_map_generator();



        return ext;
    }








}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{

    private uint cellsize;
    private uint mazesize;

    List<uint[][]> cells = new List<uint[][]>();

    public void cells_init()
    {
        cells.Add(new uint[][] 
        { 
            new uint[]{1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1 },
            new uint[]{1,0,0,0,1,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1 },
            new uint[]{1,0,0,0,1,0,1,1,1,1,0,0,0,0,0,1,0,1,0,0,0,0,0,0,1 },
            new uint[]{1,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,1,0,1,1,1,1,0,1 },
            new uint[]{1,0,0,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,0,1,0,0,0,0,1 },
            new uint[]{1,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,1,0,1,0,1,1,1,1 },
            new uint[]{1,0,0,0,1,1,1,0,0,0,0,0,0,0,1,0,0,1,0,1,0,1,0,0,1 },
            new uint[]{1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,1,0,0,0,0,1 },
            new uint[]{1,0,0,1,0,0,0,1,1,1,0,0,0,0,1,0,0,1,0,1,1,1,1,1,1 },
            new uint[]{1,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,1 },
            new uint[]{1,1,0,0,0,0,0,1,0,1,0,0,4,0,1,1,1,1,0,0,0,0,0,0,1 },
            new uint[]{1,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,1 },
            new uint[]{0,0,0,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,1,0,0 },
            new uint[]{1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,1,0,0,0,0,0,0,1 },
            new uint[]{1,0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,0,1,0,0,0,0,0,0,1 },
            new uint[]{1,1,1,1,1,1,1,1,0,0,0,0,1,0,1,0,0,1,1,1,1,1,0,0,1 },
            new uint[]{1,0,0,0,0,1,0,1,0,0,0,0,1,0,1,1,1,1,0,0,0,1,0,0,1 },
            new uint[]{1,0,1,1,1,0,0,1,0,0,0,0,0,0,0,0,0,1,1,1,0,1,0,0,1 },
            new uint[]{1,0,1,0,1,0,0,0,0,1,1,1,1,0,0,0,0,1,0,0,0,1,0,0,1 },
            new uint[]{1,0,1,0,0,0,0,1,0,1,0,0,0,0,0,1,1,1,0,1,1,1,0,0,1 },
            new uint[]{1,0,1,0,1,0,0,1,0,1,1,1,1,0,0,0,0,1,0,0,0,0,0,0,1 },
            new uint[]{1,0,1,0,1,0,0,1,0,1,0,0,0,0,0,0,0,1,1,0,1,1,1,1,1 },
            new uint[]{1,0,1,0,1,0,0,1,0,1,0,0,0,1,1,1,1,1,0,0,0,0,0,0,1 },
            new uint[]{1,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,1 },
            new uint[]{1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1 }

        }
        
        
        
        
        
        );
    }



    //creates an empty maze with only exterieur walls 
    //to be used in maze creation methods
    /**
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
    */






    //creates a small matrice which creates a blueprint 
    public int[,] cell_layout()
    {
        int[,] ext = new int[3, 3];
        int len = cells.Count;
        int elt;

        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (y == 1 && x == 1)
                {
                    ext[y, x] = 0; 
                }
                else
                {
                    //can't work with only the spawn cell in the code
                    //must add more cell for it to work

                    elt = Random.Range(1, len);
                    ext[y, x] = elt;
                }
            }
        }



        return ext;
    }





    //creates the randomized map that reading_construction.cs can use  
    public uint[][] random_gen() 
    {



        cellsize = (uint)cells[0].Length;
        mazesize = (cellsize * 3) + 2;
        uint[][] ext = new uint[mazesize][];
        int[,] matrice = cell_layout();
        uint[] line = new uint[mazesize];




        for (int i = 0; i< mazesize ;i++)
        {
            line[i] = 1;
        }
        (ext[0], ext[mazesize - 1]) = (line, line);

        


        for (uint y = 1; y < mazesize - 1; y++)
        {
            line = new uint[mazesize];
            (line[0], line[mazesize - 1]) = (1, 1);

            if (y < cellsize + 1)
            {

                for (uint i = 0; i <cellsize ; i++)
                {
                    line[1 + i] = cells[(int)matrice[0,0]] [y-1] [i];

                    line[ i + cellsize + 1] = cells[(int)matrice[0, 1]] [y - 1] [i];

                    line[i + (2*cellsize) + 1] = cells[(int)matrice[0, 2]] [y - 1] [i];

                }


            }
            else
            {
                if (y > cellsize && y < (cellsize * 2) + 1)
                {

                    for (uint i = 0; i < cellsize; i++)
                    {
                        line[1 + i] = cells[(int)matrice[1, 0]] [y-cellsize-1] [i];

                        line[i + cellsize+1] = cells[(int)matrice[1, 1]] [y - cellsize-1] [i];

                        line[i + (2 * cellsize) + 1] = cells[(int)matrice[1, 2]] [y - cellsize-1] [i];

                    }



                }
                else
                {

                    for (uint i = 0; i < cellsize; i++)
                    {
                        line[1 + i] = cells[(int)matrice[2, 0]] [y -(cellsize*2) - 1] [i];

                        line[i + cellsize+ 1] = cells[(int)matrice[2, 1]] [y - (cellsize * 2) - 1 ] [i];

                        line[i + (2 * cellsize) + 1] = cells[(int)matrice[2, 2]] [y - (cellsize * 2) - 1 ] [i];

                    }




                }
            }


            ext[y] = line;
        }
        





        return ext;
    }








}

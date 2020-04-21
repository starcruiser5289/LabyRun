﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sav
{
    public class Test
    {
        public uint[][] cell;




        public void Starting()
        {
            cell = new uint[][]
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

            };

            cell_list cl = new cell_list();
            saver sv = new saver();
            cl.cell_add(cell);

            sv.Saving(cl.savejson(), "/saves/cell_list");
            Debug.Log(cl.savejson());
        }


    }
}

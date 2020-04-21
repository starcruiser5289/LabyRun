using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sav
{
    public class save_load
    {
        
        cell_list cl = new cell_list();
        saver sv = new saver();

        public void Starting()
        {


            
            

            
            //sv.Savinglines(new string[] { cl.cell_deconstructor(cell) }, "/saves/cell_list",false);
            
            string[] strong;
            foreach (string str in sv.Loadlines("/saves/cell_list"))
            {
                strong = str.Split('/');
                cl.cell_rebuilder(strong);
            }
            
         
            List<uint[][]> cells = cl.Cells();
            //Debug.Log(cells.Count);
            
        }


    }
}

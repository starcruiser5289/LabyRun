using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sav
{
    public class cell_list
    {

        private List<uint[][]> cells;
        private uint[][] cell;
        public uint[] line;


        

        public cell_list()
        {
            cells = new List<uint[][]> { };
            line = new uint[25];
        }

        public string savejson()
        {
            return JsonUtility.ToJson(this);
        }

        public void fromjson(string json_txt)
        {

            JsonUtility.FromJsonOverwrite(json_txt, this);
        }

        public void cell_add(uint[][] cell)
        {
            cells.Add(cell);
        }

        public List<uint[][]> Cells()
        {
            return cells;
        }


        public void cell_rebuilder(string[] arr)
        {
            uint[][] ext = new uint[25][];
            for (int i = 0; i < 25; i++)
            {
                fromjson(arr[i]);
                ext[i] = line;
            }

            cells.Add(ext);

        }

        public string cell_deconstructor(uint[][] _cell)
        {
            string ext = "";
            for(int i =0; i<25; i++)
            {
                line = _cell[i];
                ext +="/" + savejson();
            }
            return ext;
        }




    }
}

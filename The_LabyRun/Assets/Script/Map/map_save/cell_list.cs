using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sav
{
    public class cell_list
    {

        public List<uint[][]> cells;
        public List<int> test;

        public cell_list()
        {
            cells = new List<uint[][]> { };
            test = new List<int> {1,2,3,4,5,6 };
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

    }
}

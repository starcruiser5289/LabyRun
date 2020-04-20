using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell_list 
{
    
    public List<uint[][]> cells;

    public string savejson()
    {
        return JsonUtility.ToJson(this);
    }

    public void fromjson(string json_txt)
    {

        JsonUtility.FromJsonOverwrite(json_txt,this);


    }

    public void cell_add(uint[][] cell)
    {
        cells.Add(cell);
    }

}

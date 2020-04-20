using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class saver
{

    public void Saving(string txt,string fichier, bool overwrite = true)
    {
        if (File.Exists(fichier))
        {
            if (overwrite)
            {
                File.WriteAllText(fichier, txt);
            }
            else
            {
                File.AppendAllText(fichier,txt);
            }
        }
        else
        {
            File.AppendAllText(fichier,txt);
        }
    }

    public string Load(string fichier)
    {
        string ext;
        if (File.Exists(fichier))
        {
            ext = File.ReadAllText(fichier);
        }
        else
        {
            throw new System.Exception("File not found, wrong path or deleted file");
        }

            return ext;
    }


}

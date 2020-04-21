using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace sav
{
    public class saver
    {

        public void Saving(string txt, string fichier, bool overwrite = true)
        {
            if (File.Exists(Application.dataPath+fichier))
            {
                if (overwrite)
                {
                    File.WriteAllText(Application.dataPath+fichier, txt);
                }
                else
                {
                    File.AppendAllText(Application.dataPath+fichier, txt);
                }
            }
            else
            {
                File.AppendAllText(Application.dataPath+fichier, txt);
            }
        }

        public string Load(string fichier)
        {
            string ext;
            if (File.Exists(Application.dataPath+fichier))
            {
                ext = File.ReadAllText(Application.dataPath+fichier);
            }
            else
            {
                throw new System.Exception("File not found, wrong path or deleted file");
            }

            return ext;
        }


    }
}

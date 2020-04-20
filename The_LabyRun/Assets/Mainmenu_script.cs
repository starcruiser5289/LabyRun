using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu_script : MonoBehaviour
{
    public void jouer()
    {
        SceneManager.LoadScene("Scenes/Level 1"); 
    }

    public void quitter()
    {
        Application.Quit();
    }
}

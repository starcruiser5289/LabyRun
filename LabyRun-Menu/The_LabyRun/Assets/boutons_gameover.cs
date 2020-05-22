using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boutons_gameover : MonoBehaviour
{
    public void recommencer()
    {
        SceneManager.LoadScene("Scenes/Level 1");
    }

    public void quitter()
    {
        Application.Quit();
    }

    public void sahara()
    {
        SceneManager.LoadScene("Scenes/sahara");
    }
}

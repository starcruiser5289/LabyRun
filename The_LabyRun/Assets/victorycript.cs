using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victorycript : MonoBehaviour
{
    public void rejouer()
    {
        SceneManager.LoadScene("Scenes/Level 1");
    }

    public void quitter()
    {
        Application.Quit();
    }

    public void retourmenu()
    {
        SceneManager.LoadScene("Scenes/Mainmenu");
    }
}

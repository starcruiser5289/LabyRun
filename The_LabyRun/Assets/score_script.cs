using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI ;

public class score_script : MonoBehaviour
{
    public float timeStart = 90;
    public Text textBox;
    public deplacement ramzy; 
    
    
    
    void Start () {
        textBox.text = timeStart.ToString();
    }
	
    
    void Update ()
    {
        int scr = ramzy.score;
        if (Mathf.Round(timeStart) == 0 && scr < 8)
        {
            SceneManager.LoadScene("Scenes/Mainmenu"); 
        }
        timeStart -= Time.deltaTime;
        textBox.text = "Temps restant à Ramzy :" + Mathf.Round(timeStart).ToString();
    }
}

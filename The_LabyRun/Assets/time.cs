using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class time : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeStart ;
    public Text textBox;
    public deplacement ramzy; 
    
    
    
    void Start () {
        textBox.text = timeStart.ToString();
        
    }
	
    
    void Update ()
    {
        int scr = ramzy.score;
        
        
        timeStart -= Time.deltaTime;
        textBox.text = "Temps restant à Ramzy :" + Mathf.Round(timeStart).ToString();
        if (scr == 8 && Mathf.Round(timeStart) > 0 )
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
            
        }
        else if (Mathf.Round(timeStart) == 0 && scr < 8)
        {
            SceneManager.LoadScene("Scenes/gameover"); 
        }
        
    }
}

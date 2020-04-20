using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ia_entité : MonoBehaviour
{

    public float speed;
    private Transform target;
    public deplacement ramzy;
    public health_script vie;
    private int z = 0;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        vie.hp = 3;
        vie.nb_coeurs = 3;
        Random rnd = new Random();



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
            vie.hp -= 1;
            ramzy.transform.position = new Vector2(2, 2);
            Debug.Log("zzz");
        
    }



    void Update()
    {
        if (vie.hp == 0)
        {
            SceneManager.LoadScene("Scenes/Mainmenu");
        }

        if (Vector2.Distance(transform.position, target.position) < 15)
        {

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
    }
}

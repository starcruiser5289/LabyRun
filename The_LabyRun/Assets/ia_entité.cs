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
    public AudioSource degats;
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
        if (other.CompareTag("Player"))
        {
            vie.hp -= 1;
            degats.Play();
            ramzy.transform.position = new Vector2(39, 39);
            Debug.Log("zzz");
        }
    }



    void Update()
    {
        if (vie.hp == 0)
        {
            degats.Play();
            SceneManager.LoadScene("Scenes/gameover"); 
        }

        if (Vector2.Distance(transform.position, target.position) < 10)
        {

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
    }
}

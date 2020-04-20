using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{
    public Rigidbody2D rigit2d;
    public float vitesse = 5;
    private Vector3 mouvement;
    public Animator Animator; 
    public int score;
    private  AudioSource miam; 

    void Start()
    {
        rigit2d = GetComponent<Rigidbody2D>();
        score = 0;
        miam = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(  "LOL");
        Destroy(collision.gameObject);
        score += 1;

        if (collision.CompareTag("clef"))
        {
            miam.Play();
            Destroy(collision.gameObject);
            score += 1;
            Debug.Log(score + "LOL");
        }

    }
    void Update()
    {
        mouvement.y = Input.GetAxisRaw("Vertical"); 
        mouvement.x = Input.GetAxisRaw("Horizontal");
        Animator.SetFloat("Horizontal" ,mouvement.x);
        Animator.SetFloat("Vertical" ,mouvement.y);
        Animator.SetFloat("speed" , vitesse);
        
        
        
        float h = Input.GetAxis("Horizontal") * vitesse; 
        float l = Input.GetAxis("Vertical") * vitesse;
        rigit2d.velocity = new Vector2(h,l);
        
    }
}

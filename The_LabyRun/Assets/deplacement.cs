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
    public AudioSource clé;
    public AudioSource miam;
    public health_script vie;



    void Start()
    {
        rigit2d = GetComponent<Rigidbody2D>();
        score = 0;
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.CompareTag("clef"))
        {
            Destroy(collision.gameObject);
            score += 1;
            clé.Play();
            
            Debug.Log(score + "LOL");
        }

        if (collision.CompareTag("potion") && vie.hp < 3)
        {
            Destroy(collision.gameObject);
            miam.Play();
            vie.hp += 1;

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

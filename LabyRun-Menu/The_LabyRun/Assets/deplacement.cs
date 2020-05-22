using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deplacement : MonoBehaviour
{
    public Rigidbody2D rigit2d;
    public float vitesse=5 ;
    private Vector3 mouvement;
    public Animator Animator; 
    public int score;
    public AudioSource clé;
    public AudioSource miam;
    public health_script vie;
    public time temps;
    public AudioSource damage;
    public AudioSource chrono;

    private float attackTime = .5f;
    private float attackCounter = .5f;
    private bool IsAttacking;
    
    
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
            
            Debug.Log(score + "collisionclé");
        }

        if (collision.CompareTag("potion") )
        {
            Destroy(collision.gameObject);
            if (vie.hp < 3)
            {
                miam.Play();
                vie.hp += 1;
            }

        }
        if (collision.CompareTag("cheese") )
        {
            vitesse = 7; 
            Destroy(collision.gameObject);
            
        }
        if (collision.CompareTag("projectile") )
        {
            vie.hp -= 1; 
            damage.Play();
            
        }
        if (collision.CompareTag("chrono") )
        {
            Destroy(collision.gameObject);
            temps.timeStart += 30; 
            
            
        }

        if (collision.CompareTag("chrono"))
        {
            Destroy(collision.gameObject);
            chrono.Play();
        }
        
        if (collision.CompareTag("épée"))
        {
            Destroy(collision.gameObject);
            Combat.IsArmed = true;
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

        if (IsAttacking)
        {
            rigit2d.velocity = Vector2.zero;
            attackCounter -= Time.deltaTime;
            if (attackCounter <= 0)
            {
             Animator.SetBool("IsAttacking",false);
             IsAttacking = false;

            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attackCounter = attackTime;
            Animator.SetBool("IsAttacking",true);
            IsAttacking = true;
        }



    }
}

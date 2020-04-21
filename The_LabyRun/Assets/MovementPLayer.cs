using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPLayer : MonoBehaviour
{
    public float speed;
        private Rigidbody2D rb2d;
        
        void Start()
        {
            rb2d = GetComponent<Rigidbody2D> ();
            
        }
        
        void FixedUpdate()
        {
            int moveHorizontal = 0;
            int moveVertical = 0;
            
            if (Input.GetKey(KeyCode.Q))
                moveHorizontal -= 1;
            if (Input.GetKey(KeyCode.D))
                moveHorizontal += 1;
            if (Input.GetKey(KeyCode.Z))
                moveVertical += 1;
            if (Input.GetKey(KeyCode.S))
                moveVertical -= 1;
            PlayerMove(moveHorizontal,moveVertical);
            
        }
    
        void PlayerMove(float moveHorizontal, float moveVertical)
        {
            Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
            rb2d.AddForce (movement * speed * Time.deltaTime);
        }
}

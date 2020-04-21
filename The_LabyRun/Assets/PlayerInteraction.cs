using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentInterObj = null;

    private void Update()
    {
        if (Input.GetButtonDown("Interact") && currentInterObj)
        {
            //do something with the object   
            currentInterObj.SendMessage("DoInteraction");
        }     
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("INterObjet"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag ("INterObjet"))
            if (currentInterObj == other.gameObject)
                currentInterObj = null;
    }
}

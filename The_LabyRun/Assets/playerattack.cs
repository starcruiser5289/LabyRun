using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerattack : MonoBehaviour
{
    public Transform ramzy;
    private float cd;
    public float starttime;
    public GameObject projecttile; 
    

    // Update is called once per frame
    void Update()
    {
        if (cd <= 0)
        {
            Debug.Log("atack");
            if (Vector2.Distance(ramzy.position, transform.position) < 10)
            {
                Instantiate(projecttile, transform.position, Quaternion.identity);
            }

            cd = starttime; 
        }
        else
        {
            cd -= Time.deltaTime; 
        }

    }
}

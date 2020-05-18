using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chrono : MonoBehaviour
{
    public time wakt;
    public AudioSource ss;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            wakt.timeStart += 30;
            ss.Play();
        }

    }
}


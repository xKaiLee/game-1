using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{


    public movement mv;
    public Win win;
    private bool collected = false;
    private void Update()
    {
        Debug.Log("UWU");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "item")
        {
            collected = true;
            Destroy(other.gameObject);
        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("UWU");
        if (collision.collider.tag == "point")
        {
            if (collected)
            {
                if(mv.playerIndex == 1)
                {
                    collision.collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
                    collected = false;
                    win.is_colored = true;

                }
                else
                {
                    collision.collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                    collected = false;
                }

            }
        }
    }
}

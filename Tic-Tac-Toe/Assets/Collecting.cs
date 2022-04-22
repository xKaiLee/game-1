using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{


    public movement mv;
    public Coloring coloring;
    private bool collected = false;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "item" && collected == false)
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
                GameObject collidingObject1 = collision.collider.gameObject;
                Coloring coloring1 = collidingObject1.GetComponent<Coloring>();

                if (coloring1.is_colored == false)
                { 
                    if (mv.playerIndex == 1)
                    {
                        GameObject collidingObject = collision.collider.gameObject;
                        collidingObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
                        collected = false;
                        Coloring coloring = collidingObject.GetComponent<Coloring>();
                        coloring.is_colored = true;
                        coloring.is_blue = true;
                        coloring.color = "blue";

                    }
                    else
                    {
                        GameObject collidingObject = collision.collider.gameObject;
                        collision.collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                        collected = false;
                        Coloring coloring = collidingObject.GetComponent<Coloring>();
                        coloring.is_colored = true;
                        coloring.is_red = true;
                        coloring.color = "red";

                    }
                }

            }
        }
    }
}

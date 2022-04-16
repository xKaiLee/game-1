using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{



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
                collision.collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                collected = false;
            }
        }
    }
}

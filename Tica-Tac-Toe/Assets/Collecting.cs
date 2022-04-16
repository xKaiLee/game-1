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
        Debug.Log("UWU");
        if (other.tag == "point")
        {
            if (collected )
            {
                other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            }
        }





        if (other.tag == "item")
        {
            collected = true;
            Destroy(other.gameObject);
        }

    
    
        
    }
}

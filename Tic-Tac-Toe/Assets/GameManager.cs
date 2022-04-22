using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Coloring c1, c2, c3, c4, c5, c6, c7, c8, c9;
    public GameObject f1, f2, f3, f4, f5, f6, f7, f8, f9;
    
    // Update is called once per frame
    void Update()
    {
        c1 = f1.GetComponent<Coloring>();
        c2 = f2.GetComponent<Coloring>();
        c3 = f3.GetComponent<Coloring>();
        c4 = f4.GetComponent<Coloring>();
        c5 = f5.GetComponent<Coloring>();
        c6 = f6.GetComponent<Coloring>();
        c7 = f7.GetComponent<Coloring>();
        c8 = f8.GetComponent<Coloring>();
        c9 = f9.GetComponent<Coloring>();
        if ((c1.color == c2.color && c2.color == c3.color) ||
            (c4.color == c5.color && c5.color == c6.color) ||
            (c7.color == c8.color && c8.color == c9.color) ||
            (c1.color == c4.color && c4.color == c8.color) ||
            (c2.color == c5.color && c5.color == c9.color) ||
            (c3.color == c6.color && c6.color == c7.color) ||
            (c1.color == c5.color && c5.color == c7.color) ||
            (c4.color == c5.color && c5.color == c6.color))
        {
            Debug.Log("Win");
        }
    }
}

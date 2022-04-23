using System.Collections.Generic;
using UnityEngine;

public class WinChecker : MonoBehaviour
{
    // Notation:
    // 7 8 9
    // 4 5 6
    // 1 2 3
    private Coloring[] fieldsColor;

    void Start() {
        fieldsColor = new Coloring[9];
        FieldsHolder fieldsHolder = GetComponent<FieldsHolder>();
        IList<Transform> fields = fieldsHolder.getFields();

        for (int i=0; i<9; i++)
        {
            fieldsColor[i] = fields[i].GetComponent<Coloring>();
        }
    }
    
    void Update()
    {
        if (Compare(1,2,3) ||
            Compare(4,5,6) ||
            Compare(7,8,9) ||
            Compare(1,4,7) ||
            Compare(2,5,8) ||
            Compare(3,6,9) ||
            Compare(1,5,9) ||
            Compare(3,5,7))
        {
            Debug.Log("Win");
        }
    }

    private bool Compare(int i, int j, int k) {
        return fieldsColor[i-1].color == fieldsColor[j-1].color && 
                fieldsColor[j-1].color == fieldsColor[k-1].color;  
    }
}
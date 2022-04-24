using System.Collections.Generic;
using UnityEngine;

public class WinChecker : MonoBehaviour
{
    // Notation:
    // 7 8 9
    // 4 5 6
    // 1 2 3
    private Coloring[] fieldsColor;
    private string winColor;

    void Start() {
        fieldsColor = new Coloring[9];
    }
    
    public void CheckWin()
    {
        FieldsHolder fieldsHolder = GetComponent<FieldsHolder>();
        IList<Transform> fields = fieldsHolder.getFields();
        for (int i=0; i<9; i++)
        {
            fieldsColor[i] = fields[i].GetComponent<Coloring>();
        }

        if (Compare(1,2,3) ||
            Compare(4,5,6) ||
            Compare(7,8,9) ||
            Compare(1,4,7) ||
            Compare(2,5,8) ||
            Compare(3,6,9) ||
            Compare(1,5,9) ||
            Compare(3,5,7))
        {
            Debug.Log("Winner is " + this.winColor);
        }
    }

    private bool Compare(int i, int j, int k) {
        Color color = this.fieldsColor[i-1].GetColor();
        if (color != Color.black && 
            this.fieldsColor[j-1].GetColor() == color && 
            this.fieldsColor[k-1].GetColor() == color) 
        {
            this.winColor = color == Color.red ? "red" : "blue";
            return true;
        }
        return false;
    }
}
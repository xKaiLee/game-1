using System;
using System.Collections.Generic;
using UnityEngine;

public class FieldsHolder : MonoBehaviour
{
    // Notation:
    // 7 8 9
    // 4 5 6
    // 1 2 3
    private Transform[] fields;
    void Start()
    {
        fields = new Transform[9];
        for (int i=0; i<9; i++)
        {
            Transform field = this.transform.Find("Field"+(i+1));
            fields[i] = field;
        }
    }

    public IList<Transform> getFields() {
        return Array.AsReadOnly(this.fields);
    }
}
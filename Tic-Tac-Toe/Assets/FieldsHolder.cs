using System;
using System.Collections.Generic;
using UnityEngine;

public class FieldsHolder : MonoBehaviour
{
    // Notation:
    // 7 8 9
    // 4 5 6
    // 1 2 3
    private Transform[] fields = new Transform[8];
    private Vector3[] initialPositions = {
        new Vector3(-5.5f, 0.1f, -5.5f),
        new Vector3(0.0f, 0.1f, -5.5f),
        new Vector3(5.5f, 0.1f, -5.5f),

        new Vector3(-5.5f, 0.1f, 0.0f),
        new Vector3(0.0f, 0.1f, 0.0f),
        new Vector3(5.5f, 0.1f, 0.0f),

        new Vector3(-5.5f, 0.1f, 5.5f),
        new Vector3(0.0f, 0.1f, 5.5f),
        new Vector3(5.5f, 0.1f, 5.5f)
    };
    void Start()
    {
        this.fields = new Transform[9];
        for (int i=0; i<9; i++)
        {
            Transform field = this.transform.Find("Field"+(i+1));
            field.position = this.initialPositions[i];
            this.fields[i] = field;
        }
    }

    public IList<Transform> getFields() {
        return Array.AsReadOnly<Transform>(this.fields);
    }
}
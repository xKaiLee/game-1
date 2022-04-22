using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldsSetting : MonoBehaviour
{
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
        for (int i=0; i<this.transform.childCount; i++) {
            Transform field = this.transform.GetChild(i);
            field.position = this.initialPositions[i];
        }
    }
}

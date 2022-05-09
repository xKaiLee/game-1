using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    private float counter;

    // Update is called once per frame
    void Start()
    {
        for(counter = 0; counter <=9; counter++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-40, 40), 100, Random.Range(-40, 40));
            Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        }

    }
}

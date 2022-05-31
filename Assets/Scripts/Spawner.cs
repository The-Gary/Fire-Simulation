using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    int count = 0;

    // Update is called once per frame
    void Update()
    {
        if (count < 2000)
        {
            Instantiate(prefab, transform.position, transform.rotation);
            count++;
        }
    }
}

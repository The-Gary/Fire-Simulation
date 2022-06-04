using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    [SerializeField]
    int count = 400;

    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject.Instantiate(
                prefab,
                new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)),
                Quaternion.identity
            );
        }
    }
}

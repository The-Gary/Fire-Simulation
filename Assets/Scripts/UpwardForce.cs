using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardForce : MonoBehaviour
{
    [SerializeField]
    float force = 0.5f;
    Rigidbody2D rigidBody;
    Temperature temp;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        temp = GetComponent<Temperature>();
    }

    // Update is called once per frame
    void Update()
    {
        if (temp.temp > 0)
        {
            rigidBody.AddForce(Vector2.up * temp.temp * force);
        }
    }
}

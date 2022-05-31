using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardForce : MonoBehaviour
{
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
        // add upward force to the rigidbody proportionate to the temperature
        if (temp.temp > 0)
        {
            rigidBody.AddForce(Vector2.up * temp.temp * 0.01f);
        }

    }
}

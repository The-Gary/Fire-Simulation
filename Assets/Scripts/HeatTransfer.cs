using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatTransfer : MonoBehaviour
{
    [SerializeField]
    bool isTouching = false;

    [SerializeField]
    bool heated = false;

    [SerializeField]
    float transferRate = 1f;

    Temperature temp = null;
    Temperature targetTemp = null;

    void Start()
    {
        temp = gameObject.GetComponent<Temperature>();
    }

    void Update()
    {
        if (heated && temp.temp < 100)
        {
            temp.temp += transferRate * Time.deltaTime;
        }
        else if (targetTemp.temp > temp.temp && isTouching && temp.temp < 100)
        {
            float difference = targetTemp.temp - temp.temp;
            temp.temp += difference * transferRate * Time.deltaTime;
        }
        else if (targetTemp.temp < temp.temp && isTouching && temp.temp > 1)
        {
            float difference = temp.temp - targetTemp.temp;
            temp.temp -= difference * transferRate * Time.deltaTime;
        }

        if (!isTouching && temp.temp > 1)
        {
            temp.temp -= transferRate * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Particle")
        {
            isTouching = true;
            targetTemp = other.gameObject.GetComponent<Temperature>();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Particle")
            isTouching = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Heat Source")
            heated = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Heat Source")
            heated = false;
    }
}

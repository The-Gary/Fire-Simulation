using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatTransfer : MonoBehaviour
{
    [SerializeField] bool isTouching = false;
    Temperature targetTemp = null;

    void Update()
    {
        Temperature temp = gameObject.GetComponent<Temperature>();
        if (isTouching && temp.temp != targetTemp.temp && temp.temp < 99)
        {
            temp.temp += 0.1f;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        isTouching = true;
        targetTemp = other.gameObject.GetComponent<Temperature>();
        // if (other.gameObject.tag == "Heat Source")
        // {
        //     Temperature temp = gameObject.GetComponent<Temperature>();
        //     Temperature otherTemp = other.gameObject.GetComponent<Temperature>();
        //     Debug.Log(temp.temp);
        //     if (otherTemp.temp > temp.temp)
        //     {
        //         temp.temp++;
        //     }
        // }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        isTouching = false;
    }
}

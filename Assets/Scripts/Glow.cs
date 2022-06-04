using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    Temperature temp = null;
    Light light = null;

    // Start is called before the first frame update
    void Start()
    {
        temp = gameObject.GetComponent<Temperature>();
        light = GetComponentInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = (temp.temp * 10) / 100;
        light.range = temp.temp / 100;
        light.color = new Color(
            Mathf.Lerp(0, 1, temp.temp / 100),
            Mathf.Lerp(0, 0.25f, temp.temp / 100),
            Mathf.Lerp(0, 0.25f, temp.temp / 100),
            1
        );
    }
}

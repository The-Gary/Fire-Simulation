using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    [SerializeField] public float temp = 0f;
    SpriteRenderer spriteRenderer;

    float red = 0f;
    float green = 0f;
    float blue = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color(red, green, blue);
    }

    // Update is called once per frame
    void Update()
    {
        if (temp <= 50)
        {
            red = temp / 50f;
            green = 0f;
            blue = 0f;
        }
        else if (temp > 50 && temp <= 100)
        {
            red = 1f;
            green = temp / 100f;
            blue = temp / 100f;
        }

        // change scale proportionally to temperature if gameObject tag is not Heat Source
        // if (gameObject.tag != "Heat Source")
        // {
        //     transform.localScale = new Vector3(temp / 200f, temp / 200f, 1f);
        // }

        spriteRenderer.color = new Color(red, green, blue);
    }
}

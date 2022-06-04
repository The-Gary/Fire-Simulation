using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    [SerializeField]
    public float temp = 0f;

    SpriteRenderer spriteRenderer = null;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.color = new Color((temp * 10) / 255, 0, 0, temp / 100);
        if (gameObject.tag == "Particle")
        {
            transform.localScale = new Vector3(
                Mathf.Lerp(0.5f, 1.25f, temp / 100),
                Mathf.Lerp(0.5f, 1.25f, temp / 100),
                Mathf.Lerp(0.5f, 1.25f, temp / 100)
            );
        }
    }
}

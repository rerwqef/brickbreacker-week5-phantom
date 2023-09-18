using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tre : MonoBehaviour
{
    public Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        float m = Input.GetAxis("Horizontal");
        if (m < 0)
        {
            body.velocity = Vector2.left * 5f;

        }
        else if (m > 0)
        {
            body.velocity = Vector2.right * 5f;

        }else if (m == 0)
        {
            body.velocity = Vector2.zero;

        }

    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        var rigidBody = GetComponent<Rigidbody2D>();
        var transform = GetComponent<Transform>();
        if (Input.GetKey("right"))
        {
            rigidBody.velocity = new Vector2(5, 0);
        }
        if (Input.GetKey("left"))
        {
            rigidBody.velocity = new Vector2(-5, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            rigidBody.velocity = new Vector2(0, 10);
        }
        if (transform.position.y < -6)
        {
            if (transform.position.x < 2)
            {
                transform.position = new Vector2(-5, 2);
            }
            else
            {
                transform.position = new Vector2(2, 2);
            }
        }
    }
}

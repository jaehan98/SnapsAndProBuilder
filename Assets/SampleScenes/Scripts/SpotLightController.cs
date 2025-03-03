﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

 

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
        float h =  Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
    }

}


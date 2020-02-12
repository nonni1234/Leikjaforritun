﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform player;
    Rigidbody rb;
    GameObject pl;
    bool grounded;
    public float Force;
    public float JumpForce;

    public void Grounded() { // Runnar þegar player collidar við ground
        grounded = true;
        Debug.Log("Grounded");
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GetComponent<Transform>();
    }
  
    void FixedUpdate() {

        // Hreyfingin

        if (Input.GetKey("space") && grounded == true) { // Að hoppa
            Debug.Log("Jumped");
            grounded = false;
            rb.AddForce(0, JumpForce* Time.deltaTime,0,ForceMode.Impulse);
        }
        // wasd movement
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, Force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -Force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}

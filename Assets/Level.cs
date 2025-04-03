using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Level: MonoBehaviour
{
    Rigidbody rb;
    private bool on;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        on = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && on)
        {
            on = false;
            rb.isKinematic = false;
        }



    }
}
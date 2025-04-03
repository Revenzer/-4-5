using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Right : MonoBehaviour
{
    Rigidbody rb;
    Transform tr;
    public int mass;

    private bool on;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
        on = true;
        mass = (int)rb.mass;

    }
    void Update()
    {
        Vector3 objXZY = transform.position;

        Debug.Log(rb.mass);

        if (on && rb.mass != mass)
        {
            if (mass > 9)
            {
                mass = 9;
            }
            if (mass < 0)
            {
                mass = 0;
            }
            rb.mass = mass;
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow) && objXZY.x > 5 && on)
        {
            transform.position += new Vector3((float)-0.5, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && objXZY.x < 11.5 && on)
        {
            transform.position += new Vector3((float)0.5, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && rb.mass < 9 && on)
        {
            rb.mass += 1;
            mass = (int)rb.mass;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && rb.mass > 1 && on)
        {
            rb.mass -= 1;
            mass = (int)rb.mass;
        }
        if (Input.GetKeyDown(KeyCode.Space) && on)
        {
            on = false;
            rb.isKinematic = false;
        }



    }
}
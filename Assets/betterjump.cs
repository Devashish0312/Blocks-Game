using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterjump : MonoBehaviour
{

    public Rigidbody rb;
    public float fallMultiplier = 2.5f;
    public float jumpDegrader = 2.5f;


    public void Update()
    {
        if (rb.velocity.y <= 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }

        else
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (jumpDegrader - 1) * Time.deltaTime;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 200f;
    public float sidewaysForce = 500f;
    public float upForce = 20;
    public bool isFalling = false;
    void Update() {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.W) && isFalling == false)
        {
            
            rb.AddForce(Vector3.up * upForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        isFalling = true;



        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        isFalling = false;
    }
}


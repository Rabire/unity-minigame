using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    float speed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * speed, rb.velocity.y, verticalInput * speed);

        if (Input.GetKey("space"))
        {
            rb.velocity = new Vector3(rb.velocity.x, speed, rb.velocity.y);
        }
    }
}

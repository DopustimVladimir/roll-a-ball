using UnityEngine;
using System;

public class BallController : MonoBehaviour
{
    public float speed = 50f;

    private Rigidbody rb;
    private float moveH;
    private float moveV;

    private Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");

        movement = new Vector3(moveH, 0.0f, moveV);

        rb.AddForce(movement * speed);
    }
}

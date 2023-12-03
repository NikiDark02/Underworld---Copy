using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //public float acc = 12;
    public float jumpSpeed = 8;
    public float speed = 2;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity += new Vector2(0, jumpSpeed);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 v = rb.velocity;
        v.x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = v;


    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//How to clean up code
// Step 1) CTRL+A (Highlight all code)
// Step 2) CTRL+K+D (in that order)

//Highlight multiple lines:
//SHIFT+ALT+(Up or DOWN Arrows)

public class Player : MonoBehaviour
{
    // <access-specifier> <data type>   <variable name>
    public int lives = 3;
    public float rotationSpeed = 2;
    public float movementSpeed = 5;
    public float acceleration = 50f;
    public float deceleration = .1f;

    //Objects default to 'null'
    private Rigidbody2D rigid;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // If user presses W
        if (Input.GetKey(KeyCode.W))
        {
            // Move forward
            rigid.AddForce(transform.right * acceleration);
        }

        // If user presses S
        if (Input.GetKey(KeyCode.S))
        {
            // Move forward
            rigid.AddForce(-transform.right * acceleration);
        }

        // If user presses A
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.UpArrow))
        {
            // Move forward
            transform.rotation *= Quaternion.AngleAxis(rotationSpeed, Vector3.forward);
        }

        // If user presses D
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.DownArrow))
        {
            // Move forward
            transform.rotation *= Quaternion.AngleAxis(-rotationSpeed, Vector3.forward);
        }
        //Deceleration
        rigid.velocity += -rigid.velocity * deceleration;
    }
}

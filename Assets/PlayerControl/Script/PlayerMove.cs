using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float rotateSpeed;
    public float walkSpeed;
    public float runSpeed;
    private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        RunSpeed();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * -moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,-rotateSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }
    }

    void RunSpeed()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = runSpeed;
        }
        else moveSpeed = walkSpeed;
    }
}

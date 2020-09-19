using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5.0f;


    void Start()
    {
        
    }

    void Update()
    {
        MoveMent();
    }

    void MoveMent()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0, 0, playerSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0, 0, -playerSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(playerSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
        }
    }
}

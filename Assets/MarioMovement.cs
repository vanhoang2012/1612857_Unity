﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovement : MonoBehaviour
{

    public float speed = 10.0f;
    public float jump = 500.0f;
    public bool jumping = true;
    public int numberOfJump = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move left, right
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));

            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().SetTrigger("Run");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetTrigger("Run");
        }
        // Jump

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (numberOfJump < 2)
            {
                Debug.Log(numberOfJump);
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump));
                numberOfJump++;
                //jumping = true; 
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Ground"))
        {
            numberOfJump = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class emermy_sc : MonoBehaviour
{

    public float speed;
    public Vector2 posCurr;
    float distance;
    float temp = 0;
    bool isLeft = true;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.03f;
        distance = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posTemp = GetComponent<Transform>().position;
        
        if(isLeft)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            posTemp.x -= speed;
            temp += speed;
            if (temp > distance)
            {
                isLeft = false;
                temp = 0;
            }
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = true;
            posTemp.x += speed;
            temp += speed;
            if (temp > distance)
            {
                isLeft = true;
                temp = 0;
            }
        }
        
        GetComponent<Transform>().position = posTemp;

        
    }
}

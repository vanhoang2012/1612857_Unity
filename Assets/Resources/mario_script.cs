using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mario_script : MonoBehaviour
{
    public float speed;
    float temp = 0;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posTemp = GetComponent<Transform>().position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            posTemp.x -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            posTemp.x += speed;
        }

        GetComponent<Transform>().position = posTemp;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform target;

    public float SmoothTime = .5f;

    Vector3 velocity = Vector3.zero;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    // Max X
    public float maxX = 19.5f;
    // Min X
    public float minX = 0.8137637f;


    private void FixedUpdate()
    {
        Vector3 targetPos = target.position;

        // Vertical
        targetPos.y = Mathf.Clamp(target.position.y, 0, 0);
        // Horizontal
        targetPos.x = Mathf.Clamp(target.position.x, minX, maxX);

        targetPos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, SmoothTime);
    }

}

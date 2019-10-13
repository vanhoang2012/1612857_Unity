using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Vector3 originalPos;
    private Transform playerTransform;
    private float startPoint;
    private float tempX ;
    void Start()
    {
        originalPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        startPoint = originalPos.x;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 newPos = playerTransform.transform.position;
        if (Cameramoving()) {
            movingFunc(newPos);
        }
    }

    private void movingFunc(Vector3 newPos)
    {
        Vector3 cameraPos;
        float newDis = newPos.x - originalPos.x;
        cameraPos.x = transform.position.x + newDis;
        cameraPos.y = transform.position.y;
        cameraPos.z = transform.position.z;
        transform.position = cameraPos;
        originalPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    private bool Cameramoving()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().flipX) {
            return true;
        } else {
            return false;
        }
    }
        
}

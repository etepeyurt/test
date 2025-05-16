using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ball;
    public Vector3 gap;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gap = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ball.transform.position + gap;
    }
}

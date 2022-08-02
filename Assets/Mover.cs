using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0.0f, zValue);
    }
}

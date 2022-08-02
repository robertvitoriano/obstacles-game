using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    void Start()
    {
        PrintInstructions();
    
    }

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0.0f, zValue);
    }

    void PrintInstructions(){
        Debug.Log("Welcome to the game!");
        Debug.Log("Use the arrows in order to move the player");
        Debug.Log("Avoid the walls and obstacles");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDrop = 2.0f;
    MeshRenderer renderer;
    Rigidbody rigidBody;
    
    void Start()
    {   
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    void Update()
    {
        DetectMomentToDrop();
    }

    void DetectMomentToDrop()
    {
        if(Time.time >= timeToDrop){
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}

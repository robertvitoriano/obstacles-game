using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    float timeToDrop;
    MeshRenderer renderer;
    Rigidbody rigidBody;
    
    void Start()
    {   
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidBody.useGravity = false;
        timeToDrop = randomFloat(0f, 5.0f);
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

    float randomFloat (float min, float max){
        System.Random random = new System.Random();
        double val = (random.NextDouble() * (max - min) + min);
        return (float)val;
    }
}

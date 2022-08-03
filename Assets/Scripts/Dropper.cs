using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDrop = 2.0f;
    // Start is called before the first frame update
    MeshRenderer renderer;
    Rigidbody rigidBody;
    
    void Start()
    {   
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
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

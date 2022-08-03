using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
     Color originalColor;
     MeshRenderer renderer;

    void Start(){
        renderer = GetComponent<MeshRenderer>();
        originalColor = renderer.material.color;
    }
    
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            renderer.material.color = Color.red;
        }
    }

    private void OnCollisionExit(Collision other) {
        renderer.material.color = originalColor;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
     MeshRenderer renderer;

    void Start(){
        renderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            renderer.material.color = Color.red;
            gameObject.tag = "hit";
        }
    }
}

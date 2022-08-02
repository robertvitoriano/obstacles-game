using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDrop = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectMomentToDrop();
    }

    void DetectMomentToDrop()
    {
        if(Time.time >= timeToDrop){
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}

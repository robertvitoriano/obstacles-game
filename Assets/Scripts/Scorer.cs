using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int score = 0;
    Color originalColor;

    void Start()
    {
        originalColor = GetComponent<Renderer>().material.color;
    }
    private void OnCollisionEnter(Collision other) {
        score++;
        GetComponent<MeshRenderer>().material.color = Color.red;

        if(score == 10) {
            Debug.Log("You win! "+score+" points");
        }
    }

    private void OnCollisionExit(Collision other) {
        GetComponent<MeshRenderer>().material.color = originalColor;
    }
}

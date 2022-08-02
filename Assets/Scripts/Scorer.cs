using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int score = 0;
    private void OnCollisionEnter(Collision other) {
        score++;
        GetComponent<MeshRenderer>().material.color = Color.red;

        if(score == 10) {
            Debug.Log("You win! "+score+" points");
        }
    }

    private void OnCollisionExit(Collision other) {
        Color color = new Color();
        ColorUtility.TryParseHtmlString("#EEFD00", out color);
        GetComponent<MeshRenderer>().material.color = color;
    }
}

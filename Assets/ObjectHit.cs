using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private  void OnCollisionExit(Collision other) {
        Color color = new Color();
        ColorUtility.TryParseHtmlString("#0EFF00", out color);
        GetComponent<MeshRenderer>().material.color = color;
    }
}

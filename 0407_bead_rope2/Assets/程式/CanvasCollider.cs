using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasCollider : MonoBehaviour
{
    private float x, y;
    public Transform O, X, Y;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fingerP"))
        {
            x = Vector3.Dot(other.transform.position - O.position, X.position - O.position);
            y = Vector3.Dot(other.transform.position - O.position, Y.position - O.position);
            Debug.Log(x + "," + y);
        }
    }
}

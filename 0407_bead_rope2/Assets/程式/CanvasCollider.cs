using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ©M­±ªO¸I¼²
public class CanvasCollider : MonoBehaviour
{
    private float x, y;
    public Transform O, X, Y;
    public bool mouse = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fingerP"))
        {
            mouse = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("fingerP"))
        {
            mouse = true;
            x = Vector3.Dot(other.transform.position - O.position, X.position - O.position);
            y = Vector3.Dot(other.transform.position - O.position, Y.position - O.position);
            Debug.Log(x + "," + y);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("fingerP"))
        {
            mouse = false;
        }
    }
}

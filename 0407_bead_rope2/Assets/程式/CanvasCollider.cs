using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 和面板碰撞
public class CanvasCollider : MonoBehaviour
{
    private float x, y;
    public Transform O, X, Y;
    public GameObject mouse;
    public List<GameObject> finger = new List<GameObject>();
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Contains("finger") && !finger.Contains(other.gameObject))
        {
            finger.Add(other.gameObject);

            if(finger.Count == 1)
            {
                mouse.SetActive(true);
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (finger.Count > 0 && finger[0].Equals(other.gameObject)) // 以最先點的手指作為觸控點
        {
            x = Vector3.Dot(other.transform.position - O.position, (X.position - O.position).normalized); // 世界座標長度的x
            y = Vector3.Dot(other.transform.position - O.position, (Y.position - O.position).normalized); // 世界座標長度的y

            mouse.transform.position = O.position + (X.position - O.position).normalized * x + (Y.position - O.position).normalized * y;

            x = x * transform.GetComponent<RectTransform>().rect.width / (X.position - O.position).magnitude; // 畫布座標長度的x
            y = y * transform.GetComponent<RectTransform>().rect.height / (Y.position - O.position).magnitude; // 畫布座標長度的y

            Debug.Log(x + "," + y); // 觸控點在畫布上的座標
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (finger.Contains(other.gameObject))
        {
            finger.Remove(other.gameObject);

            if(finger.Count == 0)
            {
                mouse.SetActive(false);
            }
        }
    }
}

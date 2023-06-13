using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// æﬁ±±√Ë¿Y≤æ∞ 
public class camera_rotate : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    private float rotationSpeed = 5;
    private float moveSpeed = 10;
    private float updownSpeed = 2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
        if(Input.GetKey("q"))
        {
            transform.Translate(Vector3.down * updownSpeed * Time.deltaTime);
        }
        if (Input.GetKey("e"))
        {
            transform.Translate(Vector3.up * updownSpeed * Time.deltaTime);
        }
        /*
        float mouseXInput = Input.GetAxis("Mouse X");
        float mouseYInput = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up, mouseXInput);
        transform.Rotate(Vector3.left, mouseYInput);
        */
    }
}

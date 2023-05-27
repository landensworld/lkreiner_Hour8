using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float sensitivity = 2f; // Mouse sensitivity

    private void Update()
    {
        
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        
        transform.Rotate(Vector3.up, mouseX);
        transform.Rotate(Vector3.left, mouseY);
    }
}
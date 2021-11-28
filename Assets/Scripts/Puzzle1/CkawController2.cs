using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CkawController2 : MonoBehaviour
{
    private float sensitivity;
    private Vector3 firstPos;
    private Vector3 mouseReference;
    private Vector3 mouseOffset;
    
    
    private Vector3 rotation;
    public static bool isRotating;
     
    void Start ()
    {
        sensitivity = 0.4f;
        rotation = Vector3.zero;
    }
     
    void Update()
    {
        if(isRotating)
        {
            // offset
            mouseOffset = (Input.mousePosition - mouseReference);
             
            // apply rotation
            rotation.z = -(mouseOffset.y) * sensitivity;
            //
            // rotate
            transform.Rotate(rotation);
             
            // store mouse
            mouseReference = Input.mousePosition;
        }
        
    }
     
    void OnMouseDown()
    {
        firstPos = transform.eulerAngles;
        isRotating = true;
        mouseReference = Input.mousePosition;
    }
     
    void OnMouseUp()
    {
        isRotating = false;
        transform.eulerAngles = firstPos;
    }
}

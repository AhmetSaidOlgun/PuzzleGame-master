using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentClaw : MonoBehaviour
{
    private int speed = 5;
    public GameObject Button;
    

    // Update is called once per frame
    void Update()
    {
        if (buttonController.buttonPresed)
        {
            speed = 0;
            StartCoroutine(SpacePress());
        }
        if (ClawController.isRotating)
        {
            Vector3 Movement = new Vector3(0, 0, Input.GetAxis("Mouse X")* speed);
            transform.position += Movement * speed * Time.deltaTime;
            Debug.Log(speed);
        }
        if (CkawController2.isRotating)
        {
            Vector3 Movement = new Vector3(-Input.GetAxis("Mouse Y")* speed, 0, 0);
            transform.position += Movement * speed * Time.deltaTime;
        }
        

    }
    private IEnumerator SpacePress()
    {
        yield return new WaitForSeconds(2);
        speed = 5;
        buttonController.buttonPresed = false;
    }
}

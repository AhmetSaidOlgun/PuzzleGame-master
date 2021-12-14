using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClawMovement : MonoBehaviour
{
    
    //In this script we are controlling the child claw. We are playing the claw animation when the button is pressed. If it touches the car, the car is sticking to claw. If e pressed, we releases the car.
    //we don't use go left, right, up or down commands in this script. We are using them in the parentClaw script.

    
    
    
    private int speed = 1;

    public GameObject Claw;   
    public GameObject FollowPoint;
    public GameObject car;
    public GameObject carDropText;
    
    public Transform parentClaw;
    
    public static bool CarTouched;
   
    private void Start()
    {
        CarTouched = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    void Update()
    {
        //Vector3 Movement = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
        //transform.position += Movement * speed * Time.deltaTime;

        if (CarTouched == false && buttonController.buttonPresed)
        {          
            Claw.GetComponent<Animator>().Play("ClawMachineDown");
            buttonController.buttonPresed = false;

        }
        if (CarTouched)
        {
            car.transform.position = FollowPoint.transform.position;
            carDropText.SetActive(true);
            car.GetComponent<Rigidbody>().isKinematic = false;
            if (Input.GetKey("e"))
            {
                carDropText.SetActive(false);
                CarTouched = false;
                car.GetComponent<Rigidbody>().useGravity = true;             
            }

        }

        if(Car.carExit && Input.GetKey("f"))
        {
            SceneManager.LoadScene("PuzzleScene");
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Car")
        {
            Debug.Log("Car");
            changeParent();                       
        }
        if (other.tag == "pineaplle" || other.tag == "Star" || other.tag == "Robot")
        {            
            Destroy(other.gameObject);
        }
    }
    
    public void changeParent()
    {
        CarTouched = true;
    }
}
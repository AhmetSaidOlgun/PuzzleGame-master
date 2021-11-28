using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public static bool puzzleTwoSuccessfull;
    public static bool puzzleTwoFail;
    private float SpeedX;
    private float SpeedY;
    private float SpeedZ;

    private float RotateX;
    private float RotateY;
    private float RotateZ;


    private void Start()
    {
        puzzleTwoSuccessfull = false;
        puzzleTwoFail = false;
        SpeedZ = -0.005f;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    void Update()
    {
        MovementCar();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Corner1")
        {
            SpeedZ = 0;
            SpeedX = 0.005f;
            RotateY = -90;
            RotateCar();
        }
        
        if(other.tag == "Corner2")
        {
            SpeedX = 0;
            SpeedZ = 0.005f;
            RotateY = -90;
            RotateCar();
        }
        if(other.tag == "Corner3")
        {
            SpeedZ = 0;
            SpeedX = 0.005f;
            RotateY = 90;
            RotateCar();
        }
        if (other.tag == "Corner4")
        {
            SpeedX = 0;
            SpeedZ = -0.005f;
            RotateY = 90;
            RotateCar();
        }
        if (other.tag == "Corner5")
        {
            SpeedZ = 0;
            SpeedX = 0.005f;
            RotateY = -90;
            RotateCar();
        }
        if (other.tag == "Corner6")
        {
            SpeedX = 0;
            SpeedZ = 0.005f;
            RotateY = -90;
            RotateCar();
        }
        if (other.tag == "Corner7")
        {
            SpeedZ = 0;
            SpeedX = 0.005f;
            RotateY = 90;
            RotateCar();
        }
        if (other.tag == "Corner8")
        {
            SpeedX = 0;
            SpeedZ = -0.005f;
            RotateY = 90;
            RotateCar();
        }
        if (other.tag == "Obstacle")
        {
            puzzleTwoFail = true;
            Destroy(this.gameObject);
            ClawMovement.CarTouched = false;
            Car.carExit = false;
            AreaEntering.puzzleTwoArea = false;
            AreaEntering.clawAreaEntering = false;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "PuzzleTwoFinish")
        {
            puzzleTwoSuccessfull = true;
            Debug.Log("puzzle two accamplished successfully");
            Destroy(this.gameObject);
        }
    }

    void MovementCar()
    {
        transform.position += new Vector3(SpeedX, SpeedY, SpeedZ);
    } 
    void RotateCar()
    {
        this.transform.Rotate(RotateX, RotateY, RotateZ, Space.World);
    }
    
}

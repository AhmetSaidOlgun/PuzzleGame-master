using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    private void OnMouseDown()
    {
        this.transform.Rotate(0, 90.0f, 0.0f, Space.World);
    }
}

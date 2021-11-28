using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject RedLight;
    void Update()
    {
        if (!Switch1.sw1 && !Switch2.sw2 && !Switch3.sw3 && !Switch4.sw4)
        {
            RedLight.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleTwoManager : MonoBehaviour
{
    public GameObject puzzleTwoSuccessfulTxt;
    public GameObject puzzleTwoFailTxt;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene("PuzzleScene");
        }

        if (CarMovement.puzzleTwoSuccessfull)
        {
            puzzleTwoSuccessfulTxt.SetActive(true);
        }
        if (CarMovement.puzzleTwoFail)
        {
            puzzleTwoFailTxt.SetActive(true);
        }
    }
}

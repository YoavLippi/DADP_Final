using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public string Intro = "Intro";

    public void onStartButtonClick()
    {
        SceneManager.LoadScene(Intro);
        Cursor.lockState = CursorLockMode.None;
    }
}

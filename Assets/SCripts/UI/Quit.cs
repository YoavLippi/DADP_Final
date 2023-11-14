using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Quit : MonoBehaviour
{
    public string QuitScene = "MainStartScene";
    public void OnQuitButtonClick()
    {
        Application.Quit();
        SceneManager.LoadScene(QuitScene);
        Debug.Log("Quit button was clicked");
    }
}

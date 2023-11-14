using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Pause : MonoBehaviour
{
    public GameObject pausePanel; // Reference to the pause panel in the UI Canvas
    public Button pauseButton; // Reference to the pause button in the UI Canvas
    public Button resumeButton;
    private bool isPaused = false; // Flag to track if the game is paused

    private void Start()
    {
        // Assign the onClick event to the PauseGame method when the game starts
        if (pauseButton != null)
        {
            pauseButton.onClick.AddListener(PauseGame);
            Cursor.lockState = CursorLockMode.Locked;


        }

        if (resumeButton != null)
        {
            resumeButton.onClick.AddListener(ResumeGame);
        }
    }

    private void Update()
    {
        // Check for the Escape key to also toggle pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0; // Pause the game by setting time scale to 0
            pausePanel.SetActive(true); // Activate the pause panel
            Cursor.lockState = CursorLockMode.None; // Unlock the cursor
            Cursor.visible = true; // Make the cursor visible
        }
        else
        {
            Time.timeScale = 1; // Unpause the game by setting time scale to 1
            pausePanel.SetActive(false); // Deactivate the pause panel
            Cursor.lockState = CursorLockMode.Locked; // Lock the cursor
            Cursor.visible = false; // Hide the cursor
        }
    }

    public void PauseGame()
    {
        TogglePause();
    }
    public void ResumeGame()
    {
        TogglePause(); // Resume the game by toggling the pause state
    }
}

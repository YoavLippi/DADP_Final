using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Options : MonoBehaviour
{
    public GameObject optionsPanel; // Reference to your options panel GameObject
    public Button optionsButton; // Corrected variable name

    private void Start()
    {
        // Assuming you are attaching this script to the button in the Inspector
        if (optionsButton != null)
        {
            optionsButton.onClick.AddListener(ToggleOptionsPanel);
        }
    }

   public void ToggleOptionsPanel()
    {
        Debug.Log("Button Clicked!"); // Add this line for debugging
        if (optionsPanel != null)
        {
            optionsPanel.SetActive(!optionsPanel.activeSelf);
        }
    }
}

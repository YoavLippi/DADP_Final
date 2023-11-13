using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class PlayerManager : MonoBehaviour
{
    #region Singleton

    public static PlayerManager instance;

    private void Awake()
    {
        instance = this; 
    }

    #endregion

    public GameObject player;

    public int initialHealth = 100; 
    private int currentHealth; 
    public Text gameOverText; 

    void Start()
    {
        currentHealth = initialHealth; 
        UpdateHealthUI(); 
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthUI(); 

        if (currentHealth <= 0)
        {
            GameOver();
        }
    }

    void UpdateHealthUI()
    {
        // Update the UI text to show the current health
        // Assuming you have a UI text element to display health, update it here.
        // Example: healthText.text = "Health: " + currentHealth;
    }

    void GameOver()
    {
        // Set the game over UI panel as active (visible)
        gameOverText.gameObject.SetActive(true);
        // Optionally, you can pause the game or perform other game-over-related actions here.
    }
}


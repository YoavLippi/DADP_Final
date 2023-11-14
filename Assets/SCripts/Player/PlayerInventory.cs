using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class PlayerInventory : MonoBehaviour
{
    public int NumberOfBodyParts { get; private set; } = 0; 
    public UnityEvent<PlayerInventory> OnBodyPartsCollected;

    public int RequiredBodyParts = 4; 
    public void BodyPartsCollected()
    {
        NumberOfBodyParts++;
        OnBodyPartsCollected.Invoke(this);

        if (NumberOfBodyParts >= RequiredBodyParts)
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        SceneManager.LoadScene("WinScene");
        Cursor.lockState = CursorLockMode.None; 
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfBodyParts { get; private set; }

    public UnityEvent<PlayerInventory> OnBodyPartsCollected; 

    public void BodyPartsCollected()
    {
        NumberOfBodyParts ++;
        OnBodyPartsCollected.Invoke(this); 
    }
}

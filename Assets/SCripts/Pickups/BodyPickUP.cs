using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPickUP : MonoBehaviour
{
    //Detecting the collisions between the body parts of osiris with the player
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInvetory = other.GetComponent<PlayerInventory>(); 

        if (playerInvetory != null)
        {
            playerInvetory.BodyPartsCollected();
            gameObject.SetActive(false); 
        }
    }
}

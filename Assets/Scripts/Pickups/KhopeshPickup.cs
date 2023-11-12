using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KhopeshPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Dont forget to add a method that adds the khopesh to the player inventory. - Ashlynne
            Destroy(this.gameObject);
        }
    }
}

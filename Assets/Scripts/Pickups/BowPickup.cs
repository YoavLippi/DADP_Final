using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //don't forget to add a method to add this bow to player inventory - Ashlynne
            Destroy(this.gameObject);
        }
    }
}

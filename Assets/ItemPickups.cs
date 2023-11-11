using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickups : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            //add code to add to Inventory or just update a counter
            //Update UI
            Destroy(this.gameObject);    
        }
    }
}

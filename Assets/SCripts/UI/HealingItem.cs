using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : MonoBehaviour
{
    public float healAmount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerCollision"))
        {
            other.GetComponent<PlayerStats>().Heal(healAmount);
            Destroy(gameObject); 
        }
    }

    
    
}

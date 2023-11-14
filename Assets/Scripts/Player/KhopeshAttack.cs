using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KhopeshAttack : MonoBehaviour
{
    public bool isAttacking = false;
    private void OnTriggerEnter(Collider other)
    {
        if (isAttacking && other.CompareTag("ENEMY"))
        {
            Destroy(other.gameObject);
        }
    }
    
    
}


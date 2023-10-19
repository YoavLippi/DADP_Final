using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KhopeshAttack : MonoBehaviour
{
    public bool attacking;
    private void OnTriggerEnter(Collider other)
    {
        if (!attacking) return;
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}


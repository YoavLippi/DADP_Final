using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BowPickup : MonoBehaviour
{
    private BoxCollider _Bow;
    private float displayDuration = 1.5f;

    private void Start()
    {
        _Bow = gameObject.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _Bow.enabled = false;
            StartCoroutine(DeactivateTextAfterDelay());
        }
    }
    
    IEnumerator DeactivateTextAfterDelay()
    {
        yield return new WaitForSeconds(displayDuration);
        Destroy(this.gameObject);
    }
}

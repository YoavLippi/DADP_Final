using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TorsoPickup : MonoBehaviour
{
    private BoxCollider _Torso;
    private float displayDuration = 1.5f;

    private void Start()
    {
        _Torso = gameObject.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _Torso.enabled = false;
            StartCoroutine(DeactivateTextAfterDelay());
        }
    }
    
    IEnumerator DeactivateTextAfterDelay()
    {
        yield return new WaitForSeconds(displayDuration);
        Destroy(this.gameObject);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KhopeshPickup : MonoBehaviour
{
    public GameObject AbilityTextObj;
    public TextMeshProUGUI AbilityText;

    private BoxCollider _Khopesh;
    private float displayDuration = 1.5f;

    private void Start()
    {
        _Khopesh = gameObject.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _Khopesh.enabled = false;
            AbilityTextObj.SetActive(true);
            AbilityText.text = "Khopesh Acquired";
            StartCoroutine(DeactivateTextAfterDelay());
        }
    }
    
    IEnumerator DeactivateTextAfterDelay()
    {
        yield return new WaitForSeconds(displayDuration);
        
        AbilityText.text = "";
        AbilityTextObj.SetActive(false);
        Destroy(this.gameObject);
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BowPickup : MonoBehaviour
{
    public GameObject AbilityTextObj;
    public TextMeshProUGUI AbilityText;

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
            AbilityTextObj.SetActive(true);
            AbilityText.text = "Bow Acquired";
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

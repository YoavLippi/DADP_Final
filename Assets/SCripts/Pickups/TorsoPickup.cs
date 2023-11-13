using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TorsoPickup : MonoBehaviour
{
    public Voiceoftheking _VOTK;
    public GameObject AbilityTextObj;
    public TextMeshProUGUI AbilityText;
    public TextMeshProUGUI CounterText;
    public GameManager _GameManager;

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
            AbilityTextObj.SetActive(true);
            AbilityText.text = "Voice of the king upgraded!";
            _GameManager.increaseBodyPartCount();
            CounterText.text = "Bodyparts collected: " + _GameManager.BodyPartsCount;
            StartCoroutine(DeactivateTextAfterDelay());
        }
    }
    
    IEnumerator DeactivateTextAfterDelay()
    {
        yield return new WaitForSeconds(displayDuration);
        
        AbilityText.text = "";
        AbilityTextObj.SetActive(false);
        _VOTK.enabled = true;
        Destroy(this.gameObject);
    }
}

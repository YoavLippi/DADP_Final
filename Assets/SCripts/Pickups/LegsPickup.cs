using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class LegsPickup : MonoBehaviour
{
    public doublejump _Doublejump;
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
            AbilityText.text = "Double Jump Acquired!";
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
        _Doublejump.enabled = true;
        Destroy(this.gameObject);
    }
}



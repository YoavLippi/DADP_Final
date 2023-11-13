using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArmsPickup : MonoBehaviour
{
    public TextMeshProUGUI CounterText;
    public GameManager _GameManager;

    private BoxCollider _Arms;


    private void Start()
    {
        _Arms = gameObject.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _Arms.enabled = false;
            _GameManager.increaseBodyPartCount();
            CounterText.text = "Bodyparts collected: " + _GameManager.BodyPartsCount;
            Destroy(this.gameObject);
        }
    }
    

}

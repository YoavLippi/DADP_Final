using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArmsPickup : MonoBehaviour
{
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
            Destroy(this.gameObject);
        }
    }
    

}

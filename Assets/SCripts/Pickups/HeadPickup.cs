using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HeadPickup : MonoBehaviour
{
    public Voiceoftheking _VOTK;
    public GameObject ExitDoor;

    private BoxCollider _Head;
    private float displayDuration = 1.5f;

    private void Start()
    {
        _Head = gameObject.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _Head.enabled = false;
            ExitDoor.SetActive(true);
            StartCoroutine(DeactivateTextAfterDelay());
        }
    }
    
    IEnumerator DeactivateTextAfterDelay()
    {
        yield return new WaitForSeconds(displayDuration);
        _VOTK.enabled = true;
        Destroy(this.gameObject);
    }
}



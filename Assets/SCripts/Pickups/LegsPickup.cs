using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class LegsPickup : MonoBehaviour
{
    public doublejump _Doublejump;
    private BoxCollider _Torso;
    private float displayDuration = 1.5f;
    public GameObject ExitDoor;

    private void Start()
    {
        _Torso = gameObject.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _Torso.enabled = false;
            ExitDoor.SetActive(true);
            StartCoroutine(DeactivateTextAfterDelay());
        }
    }
    
    IEnumerator DeactivateTextAfterDelay()
    {
        yield return new WaitForSeconds(displayDuration);
        _Doublejump.enabled = true;
        Destroy(this.gameObject);
    }
}



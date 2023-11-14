using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KhopeshPickup : MonoBehaviour
{
    public GameObject _Khopesh;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _Khopesh.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}

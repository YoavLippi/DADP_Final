using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public GameObject UIpanel;

    private void Start()
    {
        UIpanel.SetActive(false); 
    }

    private void OnTriggerEnter(Collider other)
    {
        UIpanel.SetActive(true); 
    }

    private void OnTriggerExit(Collider other)
    {
        UIpanel.SetActive(false); 
    }
}

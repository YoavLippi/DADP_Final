using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : MonoBehaviour
{
    public GameObject UIpanel;

    private void Start()
    {
        UIpanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        UIpanel.SetActive(true);
        StartCoroutine(DeactivatePanelAfterDelay());
    }

    private void OnTriggerExit(Collider other)
    {
        // If you want to immediately deactivate the panel when leaving the trigger, you can remove this line
        UIpanel.SetActive(false);
    }

    IEnumerator DeactivatePanelAfterDelay()
    {
        yield return new WaitForSeconds(5f);
        UIpanel.SetActive(false);
    }
}

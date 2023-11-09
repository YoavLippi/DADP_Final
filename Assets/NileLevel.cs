using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NileLevel : MonoBehaviour
{
    public SceneLoader _sceneLoader;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NileRiver"))
        {
            _sceneLoader.LoadNileScene();
        }
    }
}


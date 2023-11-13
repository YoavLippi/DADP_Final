using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitLevel : MonoBehaviour
{
    public SceneLoader _SceneLoader;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _SceneLoader.LoadTheHub();    
        }    
    }

    

    
}

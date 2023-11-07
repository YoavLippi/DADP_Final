using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollisionManager : MonoBehaviour
{
    private SceneLoader _sceneLoader;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NileRiver"))
        {
            _sceneLoader.LoadNileScene();  
        }
        
    }
}

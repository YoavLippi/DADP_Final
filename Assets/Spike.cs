using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    //playerHealthref
    public SceneLoader _sceneLoader;
    
    private void OnTriggerEnter(Collider other)
    {
        //Kill player
        _sceneLoader.LoadEndScene();        
    }
}

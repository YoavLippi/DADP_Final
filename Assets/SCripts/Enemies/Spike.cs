using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    public SceneLoader _sceneManager;
    private void OnTriggerEnter(Collider other)
    {
        _sceneManager.loadEndScene();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private SceneLoader _sceneLoader;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerCollision"))
        {
            _sceneLoader .LoadNileScene();
        }
    }
}

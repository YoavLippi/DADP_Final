using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class waterdamage : MonoBehaviour
{
    public SceneLoader _sceneLoader;
  
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with water");
        if (other.CompareTag("PlayerCollision"))
        {
            _sceneLoader.loadEndScene();
        }

    }
}

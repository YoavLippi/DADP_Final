using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinLevels : MonoBehaviour
{
    public SceneLoader _sceneLoader;
    
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("NileRiver"))
            {
                _sceneLoader.LoadNileScene();
            }
            
            if (other.CompareTag("PyramidsOfGiza"))
            {
                _sceneLoader.LoadPyramidsOfGiza();
            }
            
            if (other.CompareTag("ValleyOfKings"))
            {
                _sceneLoader.LoadPyramidsOfGiza();
            }

            if (other.CompareTag("TempleOfRa"))
            {
                _sceneLoader.LoadPyramidsOfGiza();
            }
            

        }
    
}


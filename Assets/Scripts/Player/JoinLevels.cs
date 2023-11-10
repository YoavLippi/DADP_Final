using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinLevels : MonoBehaviour
{
    public SceneLoader _sceneLoader;
    public GameObject NileDoor;
    public GameObject ValleyDoor;
    public GameObject TempleOfRaDoor;
    public GameObject PyramidsOfGizaDoor;
    public GameObject TutorialDoor;

    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("NileRiver"))
            {
                _sceneLoader.LoadNileScene();
                Destroy(NileDoor);
            }
            
            if (other.CompareTag("PyramidsOfGiza"))
            {
                _sceneLoader.LoadPyramidsOfGiza();
                Destroy(PyramidsOfGizaDoor);
            }
            
            if (other.CompareTag("ValleyOfKings"))
            {
                _sceneLoader.LoadPyramidsOfGiza();
                Destroy(ValleyDoor);
            }

            if (other.CompareTag("TempleOfRa"))
            {
                _sceneLoader.LoadPyramidsOfGiza();
                Destroy(TempleOfRaDoor);
            }

            if (other.CompareTag("TutorialScene"))
            { 
                _sceneLoader.LoadTutorialScene();
                Destroy(TutorialDoor);

            }



















        }
    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public Transform cameraPostition;

    private void Update()
    {
        transform.position = cameraPostition.position; 
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movesplane : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> gameObjects;
    Vector3 point, moveto;
    public GameObject boat;
    Vector3 boatlocation;
    public float speed;
    int currentIndex = 0;
    public GameObject plane;
    float temp = 4;
    float timer;
    Vector3 previouse;
    public float rotationSpeed = 5;

    //rotate




    void Start()
    {
        // Set the initial parent of the plane
        SetPlaneParent();
        Debug.Log(currentIndex);
    }

    void Update()
    {
        moveto = (gameObjects[currentIndex].transform.position + boatlocation);

        if (moveto.magnitude < temp)
        {
            temp += 2;
            gameObjects[currentIndex].SetActive(false);
            currentIndex++;
            Debug.Log(currentIndex);
            SetPlaneParent();

        }
        Quaternion targetRotation = Quaternion.LookRotation(gameObjects[currentIndex].transform.position - transform.position);


        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        Debug.Log((boatlocation - gameObjects[currentIndex].transform.position).magnitude);

        gameObjects[currentIndex].transform.position = Vector3.MoveTowards(gameObjects[currentIndex].transform.position, boat.transform.position, 0 * Time.deltaTime);
    }



    void SetPlaneParent()
    {
        if (currentIndex < gameObjects.Count)
        {
            plane.transform.parent = gameObjects[currentIndex].transform;
        }
        else
        {
            Debug.LogWarning("Index out of range. Ensure your list has enough elements.");
        }
    }
    /*private void FixedUpdate()
    {
      
    }
    
    }*/


}

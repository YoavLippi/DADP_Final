using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplane : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> checkpoiints;
    
    public GameObject boat;
    Vector3 boatlocation;
    public float speed;
    int currentIndex = 0;
    public GameObject plane;
    float temp = 4;
    float timer;
    Vector3 previouse;
    public float rotationSpeed = 5;
    public PlayerStats ps;
   
    //rotate




    void Start()
    {
        // Set the initial parent of the plane
        
    }

    void Update()
    {  transform.position = Vector3.MoveTowards(transform.position, checkpoiints[currentIndex].transform.position, speed * Time.deltaTime);

        if (checkpoiints[currentIndex].transform.position == transform.position)
        {
            currentIndex++;

            // Check if currentIndex exceeds the number of checkpoints
            if (currentIndex >= checkpoiints.Count)
            {
                currentIndex = 0; // Reset to the first checkpoint
            }
        }

        int previousIndex = Mathf.Max(0, currentIndex - 1); // Ensure the index is not negative
        Quaternion targetRotation = Quaternion.LookRotation(checkpoiints[currentIndex].transform.position - checkpoiints[previousIndex].transform.position) * Quaternion.Euler(0, 90, 0);

        boat.transform.rotation = Quaternion.Slerp(boat.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
      //  Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "player")
        {
            ps.TakeDamage(100);
        }
    }




}
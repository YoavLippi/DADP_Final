using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrainmanager : MonoBehaviour
{
    public int counter=0;
    public List<GameObject> checkpoints;
    public GameObject map;
    public float speed, rotationspeed;
    public GameObject boat;

    Vector3 lookat;

    private void FixedUpdate()
    {
       
        transform.position = Vector3.MoveTowards(transform.position, checkpoints[counter].transform.position, speed * Time.deltaTime);
        //Debug.Log((transform.position - checkpoints[counter].transform.position).magnitude);
        if ((transform.position - checkpoints[counter].transform.position).magnitude<1)
        {
            counter++;
        }
        /*        Quaternion targetRotation = Quaternion.LookRotation(checkpoints[counter].transform.position - transform.position);


                boat.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationspeed * Time.deltaTime);*/
        lookat = (checkpoints[counter].transform.position - checkpoints[counter - 1].transform.position);
        
        Quaternion targetRotation = Quaternion.LookRotation(lookat) * Quaternion.Euler(0, 90, 0);


        boat.transform.rotation = Quaternion.Slerp(boat.transform.rotation, targetRotation, rotationspeed * Time.deltaTime);
      
        //boat.transform.rotation = Quaternion.LookRotation(lookat);


    }



    public void boatlookat()
    {

    }
}

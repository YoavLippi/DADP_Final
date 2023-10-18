using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempmovement : MonoBehaviour
{
    // Start is called before the first frame update
  
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour
{
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
         public KeyCode keys;
    public float rightangle, currentangle;
 

    private void Update()
    {
        if (Input.GetKeyDown(keys))
        {
            Debug.Log("rotate");
            transform.Rotate(90, 0, 0);
        }
       

    }

}

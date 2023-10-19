using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doublejump : MonoBehaviour
{
   
    public int jumps=2;

    CharacterController Cr;
    float jumpforce;

    private void Start()
    {
        Cr = this.GetComponent<CharacterController>();
    }
   /* private void OnTriggerEnter(Collider other)
    {
        jumps = 2;
    }
*/
    private void Update()
    {
        if (Physics.Raycast(transform.position,Vector3.down, 0.7f))
        {
            jumps = 2;
        }
            if (Input.GetKeyDown(KeyCode.Space))

        {
            if (jumps>0)
            {
                jumps--;
                Cr.attachedRigidbody.AddForce(Vector3.up * jumpforce);
                
                
            }
        }
    }
}

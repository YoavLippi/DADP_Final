using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doublejump : MonoBehaviour
{
   
    public int jumps=2;

    public CharacterController Cr;
   public float jumpforce;

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
        if (Cr.isGrounded)
        {
            jumps = 2;
        }
            if (Input.GetKeyDown(KeyCode.Space))

        {
            if (jumps>0)
            {
                Debug.Log("got here");
                jumps--;
                Cr.Move(Vector3.up * jumpforce);
                //Cr.attachedRigidbody.AddForce(Vector3.up * jumpforce);
                
                
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterdamage : MonoBehaviour
{
   public  PlayerStats ps;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {


            //Debug.Log("took damage");
           
            ps.TakeDamage(100);
        }

    }
}

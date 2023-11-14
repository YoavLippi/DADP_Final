using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear2 : MonoBehaviour
{ 
    // Start is called before the first frame update

    public KeyCode keys;
    public ParticleSystem parts;
    public bool correctvalue;
    public int counter = 0;


    private void Update()
    {
        if (Input.GetKeyDown(keys))
        {
            //  Debug.Log("rotate");
            transform.Rotate(90, 0, 0);
            counter++;

        }

        switch (counter)
        {
            case 3:
                parts.startSize = 0f;
                correctvalue = false;
                break;

            case 2:
                parts.startSize = 0.5f;
                correctvalue = false;
                // Add actions for case 2
                break;

            case 1:
                parts.startSize = 1f;
                correctvalue = true;
                // Add actions for case 3
                break;

            case 4:
                parts.startSize = 0.5f;
                correctvalue = false;
                // Add actions for default case
                break;
        }
        if (counter==5)
        {
            counter = 1;
        }



    }

}



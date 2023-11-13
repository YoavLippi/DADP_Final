using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatae : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("rotate");
        transform.Rotate(0, 90, 0);
    }


}

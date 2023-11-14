using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disspaearwall : MonoBehaviour
{
    // Start is called before the first frame update
    public gear2 r1 ;
    public GameObject wall;

    // Update is called once per frame
    void Update()
    {
        if (r1.counter==3)
        {
            wall.SetActive(false);
        }else
        {
            wall.SetActive(true);
        }
    }
}

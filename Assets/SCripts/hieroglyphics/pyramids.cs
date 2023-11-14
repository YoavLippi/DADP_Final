using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyramids : MonoBehaviour
{
    public GameObject player;
    public bool hascollided;
    public Transform tp;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      /*  Debug.Log(player.transform.position);
        Debug.Log((player.transform.position - transform.position).magnitude);*/
        if ((player.transform.position - transform.position).magnitude < 3)
        {

            transform.position = tp.position;
            hascollided = true;
        }
    }
}

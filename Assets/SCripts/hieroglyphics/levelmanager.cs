using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour
{
    public gear2 g2;
    public rotatae g1,g3;
    public pyramids p1, p2, p3;
    GameObject player;
    public bool truespinner, truespinner2,truespinner3;
    public bool pyramid1, pyramid2, pyramid3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (g1.correctvalue)
        {
            truespinner = true;
        }else
        {
            truespinner = false;
        }
        if (g2.correctvalue)
        {
            truespinner2 = true;
        
    }else
        {
            truespinner2 = false;
        }
        if (g3.correctvalue)
        {
            truespinner = true;
        }
        else
        {
            truespinner3 = false;
        }

        if (p1.hascollided==true)
        {
            pyramid1 = true;
        }
        if (p2.hascollided == true)
        {
            pyramid2 = true;
        }
        if (p3.hascollided == true)
        {
            pyramid3 = true;
        }
        if (truespinner==true&& truespinner2 == true && truespinner3 == true && pyramid1 == true && pyramid2 == true && pyramid3 == true )
        {
            //display bodypart
        }



    }
}

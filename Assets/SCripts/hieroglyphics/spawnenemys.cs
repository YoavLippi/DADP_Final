using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemys : MonoBehaviour
{
    public GameObject player;
    public bool spawnedenemy;
   public  GameObject task2;
    // Start is called before the first frame update
    private void Update()
    {
        if (!spawnedenemy)
        {
            if (player.transform.position.z < (-10) && player.transform.position.z > (-30) && player.transform.position.x > (12) && player.transform.position.x < (4))
            {
                Debug.Log(true);
                spawnedenemy = true;
                task2.SetActive(true);
            }
        }
    }
}

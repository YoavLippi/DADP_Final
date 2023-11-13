using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int Health;

    void EnemyDie()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);   
        }
    }
}

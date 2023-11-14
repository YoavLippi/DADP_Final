using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float damageAmount;
    public float damageInterval;
    private bool onCooldown = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerCollision"))
        {
            if (!onCooldown)
            {
                StartCoroutine(InflictDamage(other.gameObject));    
            }
           
        }
    }
    

    private IEnumerator InflictDamage(GameObject player)
    {
        player.GetComponent<PlayerStats>().TakeDamage(damageAmount);
        onCooldown = true;
        yield return new WaitForSeconds(damageInterval);
        onCooldown = false;

    }
    
}

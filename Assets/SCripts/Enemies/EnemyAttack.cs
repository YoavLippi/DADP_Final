using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float damageAmount;
    public float damageInterval;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerCollision"))
        {
            Debug.Log("Colliding");
            StartCoroutine(InflictDamageRepeatedly(other.gameObject));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerCollision"))
        {
            StopCoroutine(InflictDamageRepeatedly(other.gameObject));
        }
    }

    private IEnumerator InflictDamageRepeatedly(GameObject player)
    {
        while (true)
        {
            yield return new WaitForSeconds(damageInterval);
            player.GetComponent<PlayerStats>().TakeDamage(damageAmount);
        }
    }
}

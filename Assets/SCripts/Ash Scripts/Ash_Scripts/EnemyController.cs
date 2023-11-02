using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;
    public float normalSpeed = 5f; // Default speed of the enemy
    public float increasedSpeed = 8f; // Faster speed when player is within the look radius

    Transform target;
    NavMeshAgent agent;

    private void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = normalSpeed; // Set default speed
    }

    private void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                // Attack the player
                FaceTarget();
            }

            // Adjust the speed if the player is within the look radius
            agent.speed = distance <= agent.stoppingDistance ? normalSpeed : increasedSpeed;
        }
        else
        {
            // Reset to default speed if the player is out of range
            agent.speed = normalSpeed;
        }
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Assuming the enemy does 10 damage to the player on collision
            PlayerManager.instance.TakeDamage(10);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }



}

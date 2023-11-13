using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieEnemy : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 10.0f;
    public float rotationSpeed = 3.0f;

    public NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        if (navMeshAgent == null)
        {
            Debug.LogError("NavMeshAgent component not found on the enemy GameObject.");
        }
    }

    void Update()
    {
        if (player != null)
        {
            // Detection range
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);
            if (distanceToPlayer <= detectionRange)
            {
                // Enemy rotates toward player
                Vector3 directionToPlayer = player.position - transform.position;
                directionToPlayer.y = 0;
                Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

                
                if (navMeshAgent != null)
                {
                    navMeshAgent.SetDestination(player.position);
                }
            }
            else
            {
                // Outside range
                if (navMeshAgent != null)
                {
                    navMeshAgent.ResetPath();
                }
            }
        }
    }
}
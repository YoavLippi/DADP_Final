using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrocoEnemyScript : MonoBehaviour
{
    public Transform player; 
    public float moveSpeed = 3.0f; 
    public float rotationSpeed = 3.0f;

    void Update()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        directionToPlayer.y = 0;
        Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab to spawn
    public Transform[] spawnPoints; // Array of spawn points for the enemies

    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            // Instantiate enemies at each spawn point
            GameObject newEnemy = Instantiate(enemyPrefab, spawnPoints[i].position, Quaternion.identity);
        }
    }
}

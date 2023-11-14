using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab to spawn
    public Transform[] spawnPoints; // Array of spawn points for the enemies
     float spawnrate=10;
     float spawnamount=1;
     float counter;
    int itterations;
  
    void Start()
    {
        SpawnEnemies();
        Debug.Log("spawn");

    }
    private void FixedUpdate()
    {
        counter += Time.deltaTime;
        if (counter>spawnrate)
        {
            counter = 0;
            for (int i = 0; i < spawnamount; i++)
            {
                SpawnEnemies();

            }
            itterations++;

            if (itterations>2&&spawnrate>3)
            {
                spawnrate--;
                spawnamount++;
                itterations = 0;
            }


        }
        
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




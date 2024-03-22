using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    // Array of obstacle game objects to spawn
    public GameObject[] obstacles;

    // Range for spawning obstacles 
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;

    // Time variables for controlling spawning frequency
    public float timeBetweenSpawn; 
    public float minTime;
    public float maxTime;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        // Check if it's time to spawn a new obstacle
        if (Time.time > spawnTime)
        {
            // Call the Spawn method
            Spawn();

            // Set the next spawn time using a random range
            spawnTime = Time.time + Random.Range(minTime, maxTime);

        }
    }

    // Method to spawn obstacles
    void Spawn()
    {

        // Generate random positions within the specified ranges
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // Choose a random obstacle from the obstacles array
        int obstacleIndex = Random.Range(0, obstacles.Length);

        // Place the selected obstacle at the selected location
        Instantiate(obstacles[obstacleIndex], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }
}

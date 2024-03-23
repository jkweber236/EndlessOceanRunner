using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coin;

    // Range for spawning coins 
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;

    // Time variables for controlling spawning frequency
    public float timeBetweenSpawn;
    public float minTime;
    public float maxTime;
    private float spawnTime;

    // Start is called before the first frame update
    void Update()
    {
        // Check if it's time to spawn a coin
        if (Time.time > spawnTime)
        {
            // Call the Spawn method
            Spawn();

            // Set the next spawn time using a random range
            spawnTime = Time.time + Random.Range(minTime, maxTime);

        }
    }

    // Method to spawn coins
    void Spawn()
    {

        // Generate random positions within the specified ranges
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // Place a coin at the selected location
        Instantiate(coin, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}

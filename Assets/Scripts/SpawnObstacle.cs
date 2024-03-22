using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject[] obstacles;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    public float minTime;
    public float maxTime;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            // spawnTime = Time.time + timeBetweenSpawn;
            spawnTime = Time.time + Random.Range(minTime, maxTime);

        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        int obstacleIndex = Random.Range(0, obstacles.Length);

        Instantiate(obstacles[obstacleIndex], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }
}

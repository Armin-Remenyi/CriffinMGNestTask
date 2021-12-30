using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] randomEnemy;

    public int startSpawnTime = 10;
    public int spawnTime = 5;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", startSpawnTime, spawnTime);
    }


    void Spawn()
    {
        int spawnPoints = Random.Range(0, 5);
        int randomEnemy = Random.Range(0, 4);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(this.randomEnemy[randomEnemy], this.spawnPoints[spawnPoints].position, this.spawnPoints[spawnPoints].rotation);
    }
}

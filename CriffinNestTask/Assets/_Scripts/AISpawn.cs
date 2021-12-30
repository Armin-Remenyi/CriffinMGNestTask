using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] randomEnemy;

    public int startSpawnTime = 10;
    public int spawnTime = 3;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", startSpawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void Spawn()
    {
        int spawnPoints = Random.Range(0, 5);
        int randomEnemy = Random.Range(0, 1);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation (can be used for more enemy types)
        Instantiate(this.randomEnemy[randomEnemy], this.spawnPoints[spawnPoints].position, this.spawnPoints[spawnPoints].rotation);
    }
}

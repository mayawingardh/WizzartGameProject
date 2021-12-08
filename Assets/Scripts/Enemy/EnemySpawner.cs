using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public float spawnRate = 3f;
    float randX;
    float randY;
    float nextSpawn = 2f;
    int maxEnemies = 100;
    int enemyCounter;

    Vector2 whereToSpawn;
   
    void Start()
    {
         enemyCounter = 0;
    }

    void Update()
    {  
        //When time passed is greater than the spawnRate, spawn an enemy at a random position X and Y
        if (Time.time > nextSpawn && enemyCounter < maxEnemies)   
        {
             nextSpawn = Time.time + spawnRate;
             randX = Random.Range(21f, 21f);        //Random pos X Change values to increase random range
             randY = Random.Range(6f, 6f);        //Random pos Y Change values to increase random range
             whereToSpawn = new Vector2(randX, randY);
             GameObject cloneEnemy = Instantiate(enemy, whereToSpawn, Quaternion.identity);
             enemyCounter++;                         //Counts enemies spawned, used for reaching max amount of enemies
        } 
    }
}
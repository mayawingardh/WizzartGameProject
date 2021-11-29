using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 3f;
    float nextSpawn = 2f;
    int maxEnemies = 100;
    int enemyCounter;

    // Start is called before the first frame update
    void Start()
    {
         enemyCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {  
            //When time passed is greater than the spawnRate, spawn an enemy at a random position X and Y
        if (Time.time > nextSpawn && enemyCounter < maxEnemies)   
        {
             nextSpawn = Time.time + spawnRate;
             randX = Random.Range(-25f, 25f);        //Random pos X Change values to increase random range
             randY = Random.Range(-14f, 14f);        //Random pos Y Change values to increase random range
             whereToSpawn = new Vector2(randX, randY);
             Instantiate(enemy, whereToSpawn, Quaternion.identity);
             enemyCounter++;                         //Counts enemies spawned, used for reaching max amount of enemies
        } 
    }
}
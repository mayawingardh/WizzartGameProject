using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Transform player;
    public GameObject lollipop;

    private float timeBtwShots;
    public float fireRate; 

    // Start is called before the first frame update
    void Start()
    {
        timeBtwShots = fireRate;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Governs how long it takes for the enemy to attack again
        if (timeBtwShots <= 0)
        {
            Instantiate(lollipop, transform.position, Quaternion.identity);
            timeBtwShots = fireRate;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
        
    }
}

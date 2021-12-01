using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour
{
    GameObject gun;
    Gun refGun;
    int ammoPU = 10;
    public GameObject objectToSpaw;
    public float spawnRate = 3f;
    float lifeTime = 5f;
    float nextSpawn = 2f;
    int maxPickUp = 1;
    int pickUpCounter;

    private void Start()
    {
        gun = GameObject.FindGameObjectWithTag("Gun");
        refGun = gun.GetComponent<Gun>();
    }

    private void Update()
    {
        spawnPickUp();
    }

    void spawnPickUp()
    {
        if (Time.time > nextSpawn && pickUpCounter < maxPickUp)
        {
            nextSpawn = Time.time + spawnRate;
            Vector2 whereToSpawn = new Vector2(Random.Range(-14f, 14f), Random.Range(-25f, 25f));
            GameObject clone= Instantiate(objectToSpaw,whereToSpawn, Quaternion.identity);
            pickUpCounter++;

            Destroy(clone, lifeTime);
        }

        pickUpCounter = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           refGun.RefillAmmo(ammoPU);

            Destroy(gameObject);
        }
    }
}
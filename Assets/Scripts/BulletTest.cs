using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTest : MonoBehaviour
{
    float speed = 10;
    public Rigidbody2D RBBullets;
    
    void Update()
    {
        RBBullets.velocity = transform.right * speed;  
    }

    //When the bullets hits enemy. Destroy enemy and its self
    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

    // TODO add collisions/triggers for the different enemies and include HP taken by them 24/11
}

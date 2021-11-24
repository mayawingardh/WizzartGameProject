using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTest : MonoBehaviour
{
    float speed = 10;
    public Rigidbody2D RBBullets;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        RBBullets.velocity = transform.right * speed;
    }

    //When the bullets hits enemy. Destroy enemy and its self
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);

        }

        Destroy(gameObject);

        if (other.tag=="Player")
        {
            Destroy(gameObject);
        }
    }
}

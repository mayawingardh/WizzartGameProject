using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    float speed = 15;
    public Rigidbody2D RBBullets;
    float destroyBullet =  0.6F;
    
    void Update()
    {
        RBBullets.velocity = transform.right * speed;
        Destroy(gameObject, destroyBullet);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyLollipopGirlBlue") || other.gameObject.CompareTag("EnemyLips") || other.gameObject.CompareTag("EnemyLollipopGirlPink"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

    // TODO add collisions/triggers for the different enemies and include HP taken by them 24/11
}

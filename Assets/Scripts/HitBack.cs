using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBack : MonoBehaviour
{

   public float knockbackStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            Vector3 direction = collision.transform.position - transform.position;
            rb.AddForce(direction.normalized*knockbackStrength, ForceMode2D.Impulse);
        }

    }
}

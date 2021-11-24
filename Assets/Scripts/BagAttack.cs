using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagAttack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)    
    
    {
        if (other.gameObject.CompareTag ("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}

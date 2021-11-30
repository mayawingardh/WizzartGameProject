using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour
{
    GameObject gun;
    Gun refGun;
    int ammoPU = 10;

    private void Start()
    {
        gun = GameObject.FindGameObjectWithTag("Gun");
        refGun = gun.GetComponent<Gun>();
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
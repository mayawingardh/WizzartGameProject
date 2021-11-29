using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour
{

    GameObject gun;
    public int playerAmmo;
    public bool isPickedUp = false;
    
    void Start()
    {
        gun = GameObject.FindGameObjectWithTag("Gun");
        playerAmmo = gun.GetComponent<Gun>().ammo;
    }

    void Update()
    {
        
        Debug.Log(playerAmmo);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ammo"))
        {
            isPickedUp = true;

            if (playerAmmo < 10)
            {
                playerAmmo = 10;
                
               
            }
             
            Destroy(other.gameObject);
        }

        
    }  
}

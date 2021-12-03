using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpAmmo : MonoBehaviour
{
    GameObject gun;
    Gun refGun;
    int ammoPU = 10;
    public AudioSource speaker;
    public AudioClip clip;
    public bool pickedUp;
    
    private void Start()
    {
        gun = GameObject.FindGameObjectWithTag("Gun");
        refGun = gun.GetComponent<Gun>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
          if (pickedUp)

          {
             return;
          }

        if (other.gameObject.CompareTag("Player"))
        {
            refGun.RefillAmmo(ammoPU);
            speaker.PlayOneShot(clip);
            GetComponent<SpriteRenderer>().enabled = false;
            pickedUp = true;
            Destroy(gameObject,5);
        }
    }
}

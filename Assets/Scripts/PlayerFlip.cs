using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    GameObject gun;
    Gun refGun;
    Transform firePoint;
    SpriteRenderer playerSpriteRenderer;
    SpriteRenderer gunSpriteRenderer;
    public Sprite playerSpriteBack;
    public Sprite playerSpriteFront;
    bool isOverY;

    // Start is called before the first frame update
    void Start()
    {
        gun = GameObject.FindGameObjectWithTag("Gun");
        refGun = gun.GetComponent<Gun>();

        playerSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        gunSpriteRenderer = gun.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        playerSpriteRenderer.flipX = refGun.firePoint.position.x > gameObject.transform.position.x;
        gunSpriteRenderer.flipY = !(refGun.firePoint.position.x > gameObject.transform.position.x);
        isOverY = refGun.firePoint.position.y > gameObject.transform.position.y;
        playerSpriteRenderer.sprite = isOverY ? playerSpriteBack : playerSpriteFront;
        gunSpriteRenderer.sortingOrder = isOverY ? 0 : 2;

        //if (isOverY)
        //{
        //    playerSpriteRenderer.sprite = playerSpriteBack;
        //    gunRenderer.sortingOrder = 0;
        //}
        //else
        //{
        //    playerSpriteRenderer.sprite = playerSpriteFront;
        //    gunRenderer.sortingOrder = 2;
        //}

    }
}

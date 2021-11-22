using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RBPlayer;
    public float speed;
    private Camera theCam;

    public Transform firePoint;

    //attatch the sprite in unity
    public GameObject playerBullets;

    void Start()
    {
        //so that you dont need to look for main camera in update. 
        theCam = Camera.main;
    }

  

    void Update()
    {
        //Player movment
        RBPlayer.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;

        //Look att the mouse
        Vector3 mouse = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);
        Vector2 offSet = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);

        //atan2 gives the angel in radian and rad2deg omvalandt to degrees
        float angle = Mathf.Atan2(offSet.y, offSet.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        if (Input.GetMouseButtonDown(0))
        {
            //spawn bullets (what, were, rotation)
            Instantiate(playerBullets, firePoint.position, transform.rotation);
        }

        //then in unity. set up firepoint (emty object connected to player) and drag it in 
    }
}

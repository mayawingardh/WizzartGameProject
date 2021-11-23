using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RBPlayer;
    public float speed;
    private Camera theCam;

    public Transform firePoint;
    public Transform bagPosition;

    //attatch the sprite in unity
    public GameObject playerBullets;
    public GameObject bag;
    public Animator animator;

    Vector2 posDif;

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

        if (Input.GetMouseButtonDown(1))
        {
            //spawn bullets (what, were, rotation)
            Instantiate(playerBullets, firePoint.position, transform.rotation);
        }

        //then in unity. set up firepoint (emty object connected to player) and drag it in fix prefab?


        animator.SetFloat("MouseHorizontal", offSet.x);

        animator.SetFloat("MouseVertikal",offSet.y);

        if (Input.GetMouseButtonDown(0))
        {
            //Lagg in animation for att sla
            //animator.SetFloat; 

            Instantiate(bag, bagPosition.position, Quaternion.identity);
        }

       
    }
}

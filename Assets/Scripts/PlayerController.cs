using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
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
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;

        //MOVE TO GUN
        //Vector3 mouse = Input.mousePosition;
        //Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);
        //Vector2 offSet = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);

        ////atan2 gives the angel in radian and rad2deg omvalandt to degrees
        //float angle = Mathf.Atan2(offSet.y, offSet.x) * Mathf.Rad2Deg;

        //transform.rotation = Quaternion.Euler(0f, 0f, angle);

        if (Input.GetMouseButtonDown(1))
        {
            //spawn bullets (what, were, rotation)
            Instantiate(playerBullets, firePoint.position, transform.rotation);
        }

        //then in unity. set up firepoint (emty object connected to player) and drag it in fix prefab?



        if (Input.GetMouseButtonDown(0))
        {
            //Lagg in animation for att sla
            //animator.SetFloat; 

            Instantiate(bag, bagPosition.position, Quaternion.identity);
        }

        animator.SetFloat("AnimHorizontal",playerInput.x);

        animator.SetFloat("AnimVertical", playerInput.y);


        animator.SetFloat("AnimVertical", playerInput.y);

    }
}

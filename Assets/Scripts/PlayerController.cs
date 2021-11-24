using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Camera theCam;

    public Transform firePoint;
    public Transform bagPosition;

    
    public GameObject playerBullets;
    public GameObject bag;
    public Animator animator;

    public float delay = 0f;

    Vector2 posDif;

    void Start()
    {
        //so that you dont need to look for main camera in update. 
       // theCam = Camera.main;
    }

  

    void Update()
    {
        //Player movment
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;

       

        //spawn bullets 
        if (Input.GetMouseButtonDown(1))
        {
            
            GameObject bullets = Instantiate(playerBullets, firePoint.position, transform.rotation);
        }

        //Bag
        if (Input.GetMouseButtonDown(0))
        {

          GameObject bag2 =  Instantiate(bag, bagPosition.position, Quaternion.identity);

           

            Destroy(bag2, 1.3f);
            
            
        }

        animator.SetFloat("AnimHorizontal",playerInput.x);
        animator.SetFloat("AnimVertical", playerInput.y);


        

    }
}

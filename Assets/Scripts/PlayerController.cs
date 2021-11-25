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
    public GameObject enemy;
   

    public float delay = 0f;

    Vector2 posDif;

    void Start()
    {



    }

    void Update()
    {
        //Player movment
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        
        transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;

        animator.SetFloat("AnimHorizontal",playerInput.x);
        animator.SetFloat("AnimVertical", playerInput.y);

        RotateAnimation();



        //spawn bullets 
        if (Input.GetMouseButtonDown(1))
        {
            
            GameObject bullets = Instantiate(playerBullets, firePoint.position, transform.rotation);
            
        }

        //Bag
        if (Input.GetMouseButtonDown(0))
        {

          GameObject bag2 =  Instantiate(bag, bagPosition.position, Quaternion.identity);
            bag2.transform.SetParent(bagPosition.transform);
            Destroy(bag2, 1.3f);

            //if animation with name "Attack" finished
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("BagAnimation"))
            {
                speed = 0;

            }


        }

        
    }


    private void RotateAnimation()
    {
        if (Input.GetAxis("Horizontal") > 0.01f)
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        else if (Input.GetAxis("Horizontal") < -0.01f)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    private Camera theCam;
    public float speed = 5;
    public float delay = 0f;
    public float bagDelay = 0.75f;

    public Transform firePoint;
    public Transform bagPosition;
    public GameObject playerBullets;
    public GameObject bag;
    public Animator animator;
    public GameObject enemy;

    public Rigidbody2D player;
    float xAxis;
    float yAxis;
    Vector2 posDif;

    void Update()
    {
        //Player movment
        //Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        xAxis = Input.GetAxisRaw("Horizontal");
        yAxis = Input.GetAxisRaw("Vertical");
        player.velocity = (new Vector2(xAxis, yAxis) * speed);

        animator.SetFloat("AnimHorizontal", xAxis);
        animator.SetFloat("AnimVertical", yAxis);

        RotateAnimation();

        //Bag
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bag2 =  Instantiate(bag, bagPosition.position, Quaternion.identity);
            bag2.transform.SetParent(bagPosition.transform);
            Destroy(bag2, bagDelay);
        }   
    }

    private void RotateAnimation()
    {
        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
            
        else if (Input.GetAxis("Horizontal") < -0.01f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }          
    }
}

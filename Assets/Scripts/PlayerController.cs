using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    private Camera theCam;
    public float speed = 5;
    public Transform firePoint; 
    public GameObject playerBullets;
    public Animator animator;
    public GameObject enemy;
    public ParticleSystem dust;
    Rigidbody2D player;
    float xAxis;
    float yAxis;
    Vector2 posDif;

    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        yAxis = Input.GetAxisRaw("Vertical");
        player.velocity = (new Vector2(xAxis, yAxis) * speed);
        RotateAnimation();  
    }


        // TODO
        //animator.SetFloat("AnimHorizontal", xAxis);
        //animator.SetFloat("AnimVertical", yAxis);

       

    private void RotateAnimation()
    {
        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            CreateDust();
        }
            
        else if (Input.GetAxis("Horizontal") < -0.01f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            CreateDust();
        }          
    }

    void CreateDust()
    {

        dust.Play();
    }
}

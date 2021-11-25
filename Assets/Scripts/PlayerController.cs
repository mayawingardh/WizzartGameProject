using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    private Camera theCam;
    public float speed = 0;
    public float delay = 0f;

    public Transform firePoint;
    public Transform bagPosition;
    public GameObject playerBullets;
    public GameObject bag;
    public Animator animator;
    public GameObject enemy;
   
    Vector2 posDif;

    void Update()
    {
        //Player movment
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        
        transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;

        animator.SetFloat("AnimHorizontal",playerInput.x);
        animator.SetFloat("AnimVertical", playerInput.y);

        RotateAnimation();

        //Bag
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bag2 =  Instantiate(bag, bagPosition.position, Quaternion.identity);
            bag2.transform.SetParent(bagPosition.transform);
            Destroy(bag2, 1.3f);
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

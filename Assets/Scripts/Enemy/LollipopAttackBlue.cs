using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LollipopAttackBlue : MonoBehaviour
{
    Transform player;
    public GameObject lollipop;
    public float fireRate; 
    float timeBtwShots;
   
    void Start()
    {
        timeBtwShots = fireRate;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        ShootLollipop();
    }

    void ShootLollipop()
    {
        //Governs how long it takes for the enemy to attack again
        if (timeBtwShots <= 0)
        {
            Instantiate(lollipop, transform.position, Quaternion.identity);
            timeBtwShots = fireRate;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        } 
    }
}

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    /* The script below came froma  separate script that controlled the lollipops instantiate and player folloing behaviour.
     * We want to incorporate that script with this one (LollipopAttack) since they are related.
     */


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Lollipop : MonoBehaviour
//{
//    Transform player;
//    Vector2 target;
//    public float speed;

//    private void Start()
//    {
//        //Makes lollipop find the position of the Player
//        player = GameObject.FindGameObjectWithTag("Player").transform;
//        target = new Vector2(player.position.x, player.position.y);
//    }

//    private void Update()
//    {
//        //Makes lollipop move towards players position and destroys lollipop when it hits Players position
//        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

//        if (transform.position.x == target.x && transform.position.y == target.y)
//        {
//            DestroyLollipop();
//        }
//    }

//    private void OnTriggerEnter2D(Collider2D other)
//    {
//        //Destroys lollipop when it hits player
//        if (other.CompareTag("Player"))
//        {
//            DestroyLollipop();
//        }
//    }

//    void DestroyLollipop()
//    {
//        Destroy(gameObject);
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LollipopPink : MonoBehaviour
{
    //LollipopGirlAIPink refLollipopGirlAIPink;
    Transform ally;
    Transform player;
    //Transform enemy;
    //Vector2 targetPlayer;
    Vector2 targetAlly;
    public float speed;

    private void Start()
    {
        //Makes lollipop find the position of the Player
        ally = GameObject.FindGameObjectWithTag("Ally").transform;
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        //enemy = GameObject.FindGameObjectWithTag("EnemyLollipopGirlPink").transform;
        targetAlly = new Vector2(ally.position.x, ally.position.y);
        //targetPlayer = new Vector2(player.position.x, player.position.y);
        //refLollipopGirlAIPink = enemy.GetComponent<LollipopGirlAIPink>();
    }

    private void Update()
    {
        //Makes lollipop move towards players position and destroys lollipop when it hits Players position
        transform.position = Vector2.MoveTowards(transform.position, targetAlly, speed * Time.deltaTime);
        if (transform.position.x == targetAlly.x && transform.position.y == targetAlly.y)
        {
            DestroyLollipop();
        }
        //if (Vector2.Distance(enemy.transform.position, player.transform.position) <= refLollipopGirlAIPink.retreatDistance)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, targetPlayer, speed * Time.deltaTime);
        //    if (transform.position.x == targetPlayer.x && transform.position.y == targetPlayer.y)
        //    {
        //        DestroyLollipop();
        //    }
        //}
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        //Destroys lollipop when it hits player
        if (other.CompareTag("Ally"))
        {
            DestroyLollipop();
        }
        if (other.CompareTag("Player"))
        {
            DestroyLollipop();
        }
    }

    void DestroyLollipop()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lollipop : MonoBehaviour
{ 
    Transform player;
    Vector2 target;
    public float speed;

    private void Start()
    {
        //Makes lollipop find the position of the Player
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    private void Update()
    {
        //Makes lollipop move towards players position and destroys lollipop when it hits Players position
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyLollipop();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Destroys lollipop when it hits player
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
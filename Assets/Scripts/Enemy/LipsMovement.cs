using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LipsMovement : MonoBehaviour
{
    GameObject lips;
    GameObject player;
    Rigidbody2D RBEnemy;
    Vector2 movement;
    public float moveSpeed = 8;

    void Start()
    {
        RBEnemy = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        lips = GameObject.FindGameObjectWithTag("EnemyLips");
    }

    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;

        //calculates angle and makes enemy face player
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        RBEnemy.rotation = angle;
        //Makes the enemy move in the direction it's facing
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveEnemy(movement);
    }

    void moveEnemy(Vector3 direction)
    {
        //Handles movement speed of the enemy
        RBEnemy.MovePosition((Vector3)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Destroys lollipop when it hits player
        if (other.CompareTag("Player"))
        {
            Destroy(lips);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    GameObject player;
    private Rigidbody2D RBEnemy;
    private Vector2 movement;
    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        RBEnemy = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LollipopPink : MonoBehaviour
{
    Transform ally;
    Vector2 target;
    public float speed;

    private void Start()
    {
        //Makes lollipop find the position of the Player
        ally = GameObject.FindGameObjectWithTag("Ally").transform;
        target = new Vector2(ally.position.x, ally.position.y);
    }

    private void Update()
    {
        //Makes lollipop move towards players position and destroys lollipop when it hits Players position
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyLollipop();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Destroys lollipop when it hits player
        if (other.CompareTag("Ally"))
        {
            DestroyLollipop();
        }
    }

    void DestroyLollipop()
    {
        Destroy(gameObject);
    }
}

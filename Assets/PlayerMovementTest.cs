using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTest : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbPlayer.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;
    }
}

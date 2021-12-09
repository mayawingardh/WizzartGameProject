using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlip : MonoBehaviour
{
    public Sprite enemySpriteFront;
    public Sprite enemySpriteBack;
    
    private SpriteRenderer enemySpriteRenderer;
    private Transform player;
    private bool isOverY;

    // Start is called before the first frame update
    void Start()
    {
        enemySpriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        enemySpriteRenderer.flipX = player.position.x < transform.position.x;
        isOverY = player.position.y > transform.position.y;
        enemySpriteRenderer.sprite = isOverY ? enemySpriteBack : enemySpriteFront;
    }
}

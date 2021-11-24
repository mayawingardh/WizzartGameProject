using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    GameObject managerGame;
    HealthController refHealthController;

    int playerHit;

    private void Start()
    {
        managerGame = GameObject.FindGameObjectWithTag("ManagerGame");
        refHealthController = managerGame.GetComponent<HealthController>();

        playerHit = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            playerHit++;

            refHealthController.CountLives(1);

            if (playerHit > 2)
            {
                Destroy(gameObject);
            }
        }
    }
}

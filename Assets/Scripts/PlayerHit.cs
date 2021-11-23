using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    GameObject managerGame;
    HealthController refHealthController;

    int playerHit;
    int hpLost = 1;

    private void Start()
    {
        // Get reference to game object - ManagerGame
        managerGame = GameObject.FindGameObjectWithTag("ManagerGame");
        refHealthController = managerGame.GetComponent<HealthController>();

        playerHit = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            playerHit++;

            refHealthController.PlayerHit(hpLost);

            if(playerHit > 2)
            {
                Destroy(gameObject);
            }
        }
    }
}

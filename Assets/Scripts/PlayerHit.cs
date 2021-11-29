using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    GameObject managerGame;
    HealthController refHealthController;
    
    int playerHit;
    int hpLost = 1;

    int playerHealthMax = 5;
    int playerHealthCurrent;

    private void Start()
    {
        managerGame = GameObject.FindGameObjectWithTag("ManagerGame");
        refHealthController = managerGame.GetComponent<HealthController>();

        refHealthController.SetMaxHealth(playerHealthMax);

        playerHit = 0;

        playerHealthCurrent = playerHealthMax;
    }

    void TakeDamage(int hpLost)
    {
        playerHealthCurrent -= hpLost;
        refHealthController.SetCurrentHealth(playerHealthCurrent);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Lollipop"))
        {
            playerHit++;

            //refHealthController.PlayerHP(hpLost);
            TakeDamage(hpLost);

            if (playerHit > 5)
            {
                Destroy(gameObject);
            }
        }
    }
}

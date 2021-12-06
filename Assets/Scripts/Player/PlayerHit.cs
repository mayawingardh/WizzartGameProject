using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    GameObject managerGame;
    PlayerHealthController refHealthController;
    
    int playerHit;
    int hpLost = 1;

    int playerHealthMax = 5;
    int playerHealthCurrent;

    private void Start()
    {
        managerGame = GameObject.FindGameObjectWithTag("ManagerGame");
        refHealthController = managerGame.GetComponent<PlayerHealthController>();

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
        if(other.gameObject.CompareTag("EnemyLollipopGirl") || other.gameObject.CompareTag("Lollipop") || other.gameObject.CompareTag("EnemyLips"))
        {
            playerHit++;

            //refHealthController.PlayerHP(hpLost);
            TakeDamage(hpLost);

            if (playerHit > 4)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("SceneRoomPopArt");
            }
        }
    }
}

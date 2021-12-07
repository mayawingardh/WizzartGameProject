using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    GameObject managerGame;
    PlayerHealthController refHealthController;
    bool invincible = false;
    
    
    int playerHit;
    int hpLost = 1;

    int playerHealthMax = 5;
    int playerHealthCurrent;

    private SpriteRenderer rend;

    public float invincibilityTime = 1.5f;

    private void Start()
    {
        managerGame = GameObject.FindGameObjectWithTag("ManagerGame");
        refHealthController = managerGame.GetComponent<PlayerHealthController>();
        rend = GetComponent<SpriteRenderer>();

        refHealthController.SetMaxHealth(playerHealthMax);

        playerHit = 0;

        playerHealthCurrent = playerHealthMax;
    }

    //andra farg
    IEnumerator color()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        rend.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        rend.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        rend.color = Color.white;
    }

    void TakeDamage(int hpLost)
    {
        playerHealthCurrent -= hpLost;
        refHealthController.SetCurrentHealth(playerHealthCurrent);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!invincible)
        {

            if (other.gameObject.CompareTag("EnemyLollipopGirl") || other.gameObject.CompareTag("Lollipop") || other.gameObject.CompareTag("EnemyLips"))
            {
                playerHit++;
                StartCoroutine(color());

                //refHealthController.
                //PlayerHP(hpLost);

                TakeDamage(hpLost);

                StartCoroutine(Invulnerability());

                if (playerHit > 4)
                {
                    Destroy(gameObject);
                    SceneManager.LoadScene("SceneRoomPopArt");
                }
            }
        }
    }
    // so that the player dont take damage after hit
    IEnumerator Invulnerability()
    {
        invincible = true;
        yield return new WaitForSeconds(invincibilityTime);
        invincible = false;
    }
}

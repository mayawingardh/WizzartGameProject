using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    // Reference to Text Canvas
    public Text textPlayerLives;

    int playerLives;

    // Start is called before the first frame update
    void Start()
    {
        playerLives = 3;
    }

    public void PlayerHit(int playerHit)
    {
        playerLives -= playerHit;
        textPlayerLives.text = string.Format("Lives: {0:03}", playerLives);
    }
}

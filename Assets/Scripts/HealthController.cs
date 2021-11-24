using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    // Connect canvas text component in inspector
    public Text textPlayerLives;

    int playerLives;

    // Start is called before the first frame update
    void Start()
    {
        playerLives = 3;
    }

    public void CountLives(int playerHit)
    {
        playerLives -= playerHit;
        textPlayerLives.text = string.Format("Lives: {00}", playerLives);
    }
}

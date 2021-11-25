using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    // Connect canvas text component in inspector
    public Text textPlayerHP;
    public Text textEnemyHP;

    // Connect canvas slider in inspector
    public Slider slider;

    //int playerHP;
    //int enemyHP;

    // Start is called before the first frame update
    void Start()
    {
        //playerHP = 3;
        //enemyHP = 5;
    }


    // TODO: connect EnemyHp to other enemies 24/11
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetCurrentHealth(int health)
    {
        slider.value = health;
    }
}

    //public void PlayerHP(int playerHit)
    //{
    //    playerHP -= playerHit;
    //    textPlayerHP.text = string.Format("Player: {00}", playerHP);
    //}

    //public void EnemyHP(int enemyHit)
    //{
    //    enemyHP -= enemyHit;
    //    textEnemyHP.text = string.Format("Enemy: {00}", enemyHP);

    //}
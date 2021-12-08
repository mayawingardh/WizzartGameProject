using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LollipopGirlAIBlue : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistancePlayer;
    public float retreatDistanceEnemy;
    public float startTimeBtwShots;
    private float timeBtwShots;

    public GameObject lollipop;
    Transform player;
    Transform lollipopGirlBlue;
    Transform lollipopGirlPink;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        lollipopGirlBlue = GameObject.FindGameObjectWithTag("EnemyLollipopGirlBlue").transform;
        lollipopGirlPink = GameObject.FindGameObjectWithTag("EnemyLollipopGirlPink").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistancePlayer)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, player.position) < retreatDistancePlayer)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
        if (timeBtwShots <= 0)
        {
            Instantiate(lollipop, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}

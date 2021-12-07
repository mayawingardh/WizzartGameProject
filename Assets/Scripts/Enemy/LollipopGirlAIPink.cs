using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LollipopGirlAIPink : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public float startTimeBtwShots;
    private float timeBtwShots;

    public GameObject lollipop;
    Transform ally;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        ally = GameObject.FindGameObjectWithTag("Ally").transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, ally.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, ally.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, ally.position) < stoppingDistance && Vector2.Distance(transform.position, ally.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        if (Vector2.Distance(transform.position, player.position) < retreatDistance)
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
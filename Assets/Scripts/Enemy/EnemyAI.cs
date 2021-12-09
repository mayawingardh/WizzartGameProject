using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{
    public Transform target;                    // reference to target
    public Transform lollipopGirlGFX;
    public float speed = 200f;
    public float nextWaypointDistance = 3f;     // how close enemy needs to be to a waypoint before moving on to the next

    private Path path;                          // current path we are following
    private int currentWaypoint = 0;            // stores current waypoint along path we are targeting
    private bool reachedEndOfPath = false;

    private Seeker seeker;
    private Rigidbody2D lollipopGirlRb;

    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        lollipopGirlRb = GetComponent<Rigidbody2D>();

        // Generate path - (start point position, target position, function to invoke when calculation of path is complete) 
        
        InvokeRepeating("UpdatePath", 0.0f, 0.5f);
    }

    void UpdatePath()
    {
        if(seeker.IsDone())
        {
            seeker.StartPath(lollipopGirlRb.position, target.position, OnPathComplete);
        }
    }

    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }

    void FixedUpdate()
    {
        // make sure we have a path to follow
        if (path == null)
        {
            return;
        }

        // make sure there are more waypoints and that we haven't reached the end
        if (currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }

        // move the enemy
        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - lollipopGirlRb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;

        lollipopGirlRb.AddForce(force);

        // distance to next waypoint
        float distance = Vector2.Distance(lollipopGirlRb.position, path.vectorPath[currentWaypoint]);

        if (distance < nextWaypointDistance)
        {
            currentWaypoint++;
        }

        // flip sprite
        if (force.x >= 0.01f)
        {
            lollipopGirlGFX.localScale = new Vector3(-0.25f, 0.25f, 1.0f);
        }
        else if (force.x <= -0.01f)
        {
            lollipopGirlGFX.localScale = new Vector3(0.25f, 0.25f, 1.0f);
        }
    }
}

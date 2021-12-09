using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject orbit;
    public Rigidbody2D enemy;

    private float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(orbit.transform.localPosition, Vector3.forward, speed * Time.deltaTime);
    }
}

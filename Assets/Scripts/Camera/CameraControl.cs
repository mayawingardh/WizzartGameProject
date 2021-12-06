using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform playerToFollow;
    public float Zoom;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    void Start()
    {
        Camera camera = Camera.main;
        minX += camera.orthographicSize * camera.aspect;
        minY += camera.orthographicSize;
        maxX -= camera.orthographicSize * camera.aspect;
        maxY -= camera.orthographicSize;
    }

    private void Update()
    {
        transform.position = new Vector3(playerToFollow.position.x, playerToFollow.position.y, Zoom);

        if(transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, Zoom);
        }

        if(transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, Zoom);
        }

        if(transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, Zoom);
        }

        if(transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, Zoom);
        }
    }
}

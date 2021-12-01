using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;
    public Camera Cam1;
    public Camera Cam2;
    public Transform playerToFollow;

    public float xOffset;
    public float yOffset;

    public Transform LeftWall;
    public Transform RightWall;
    public Transform TopWall;
    public Transform BottomWall;
    public float Width;
    public float Height;
    public float Zoom;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    //public Transform leftBound;
    //public Transform rightBound;
    //public Transform topBound;
    //public Transform bottomBound;

    //Camera gameCamera;

    Vector3 offset;
    //Vector3 targetPos;
    void Start()
    {
        Cam1.enabled = true;
        Cam2.enabled = false;
        offset = transform.position - target.transform.position;
        minX = LeftWall.transform.position.x + 10f;
        maxX = RightWall.transform.position.x - 10f;
        minY = BottomWall.transform.position.y + 10f;
        maxY = TopWall.transform.position.y - 10f;
    }

    private void Update()
    {
        transform.position = target.transform.position + offset;

        if (Input.GetKeyDown(KeyCode.C))
        {
            Cam1.enabled = !Cam1.enabled;
            Cam2.enabled = !Cam2.enabled;
        }
        //TODO Y-axis does not follow player, X-axis works as intended. When both are active it doesn't work as intended.
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

    //    if (playerToFollow.position.x > minX && playerToFollow.position.x < maxX)
    //    {
    //        // change camera's position = players position.x height.y zoom.z
    //        transform.position = new Vector3(playerToFollow.position.x, Width, Zoom);

    //    }

    //    if (playerToFollow.position.y > minY && playerToFollow.position.y < maxY)
    //    {
    //        //change camera's position = players position.x height.y zoom.z
    //        transform.position = new Vector3(Height, playerToFollow.position.y, Zoom);

    //    }
    }

    //void Start()
    //{
    //gameCamera = Camera.main;
    //    Cam1.enabled = true;
    //    Cam2.enabled = false;
    //    offset = transform.position - target.transform.position;
    //}

    //void Update()
    //{
    //    transform.position = target.transform.position + offset;

    //    if (Input.GetKeyDown(KeyCode.C))
    //    {
    //        Cam1.enabled = !Cam1.enabled;
    //        Cam2.enabled = !Cam2.enabled;
    //    }
    //}
    //private void LateUpdate()

    //Vector3 tmpPosition = transform.position;
    //targetPos = transform.position;
    //float minX = leftBound.position.x + gameCamera.orthographicSize * gameCamera.aspect;
    //float maxX = rightBound.position.x - gameCamera.orthographicSize * gameCamera.aspect;

    //tmpPosition.x = Mathf.Clamp(tmpPosition.x, minX, maxX);
    //targetPos.x = Mathf.Clamp(targetPos.x, minX, maxX);
    //float maxY = topBound.position.y - gameCamera.orthographicSize;
    //float minY = bottomBound.position.y + gameCamera.orthographicSize;
    //tmpPosition.y = Mathf.Clamp(tmpPosition.y, minY, maxY);
    //targetPos.y = Mathf.Clamp(targetPos.y, minY, maxY);
    //transform.position = tmpPosition;

}

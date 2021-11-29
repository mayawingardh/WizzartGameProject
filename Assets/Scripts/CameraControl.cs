using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;
    public Camera Cam1;
    public Camera Cam2;
    public Transform leftBound;
    public Transform rightBound;
    public Transform topBound;
    public Transform bottomBound;

    Camera gameCamera;

    Vector3 offset;
    Vector3 targetPos;
    void Start()
    {
        gameCamera = Camera.main;
        Cam1.enabled = true;
        Cam2.enabled = false;
        offset = transform.position - target.transform.position;
    }

    void Update()
    {
        transform.position = target.transform.position + offset;

        if (Input.GetKeyDown(KeyCode.C))
        {
            Cam1.enabled = !Cam1.enabled;
            Cam2.enabled = !Cam2.enabled;
        }
    }
    private void LateUpdate()
    {
        //Vector3 tmpPosition = transform.position;
        targetPos = transform.position;
        float minX = leftBound.position.x + gameCamera.orthographicSize * gameCamera.aspect;
        float maxX = rightBound.position.x - gameCamera.orthographicSize * gameCamera.aspect;

        //tmpPosition.x = Mathf.Clamp(tmpPosition.x, minX, maxX);
        targetPos.x = Mathf.Clamp(targetPos.x, minX, maxX);
        float maxY = topBound.position.y - gameCamera.orthographicSize;
        float minY = bottomBound.position.y + gameCamera.orthographicSize;
        //tmpPosition.y = Mathf.Clamp(tmpPosition.y, minY, maxY);
        targetPos.y = Mathf.Clamp(targetPos.y, minY, maxY);
        //transform.position = tmpPosition;
    }
}

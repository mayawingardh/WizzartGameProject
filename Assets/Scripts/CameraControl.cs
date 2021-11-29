using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;
    public Camera Cam1;
    public Camera Cam2;

    Vector3 offset;

    void Start()
    {
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
}

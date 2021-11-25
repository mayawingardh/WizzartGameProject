using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;
    private Vector3 offset;
    public Camera Cam1;
    public Camera Cam2;

    // Start is called before the first frame update
    void Start()
    {
        Cam1.enabled = true;
        Cam2.enabled = false;
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
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

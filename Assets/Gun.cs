using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Camera theCam;
    float speed = 10;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float angle;

    void Start()
    {
        theCam = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        //aim with mouse
        Vector2 mouse = Input.mousePosition;
        Vector2 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        Vector2 offSet = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);

        angle = Mathf.Atan2(offSet.y, offSet.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        //spawn bullets 
        if (Input.GetMouseButtonDown(0))
        {
            Fire(offSet);
        }
    }
    public void Fire(Vector2 offset)
    {
        Bullet bullet = Instantiate(bulletPrefab, firePoint.position, transform.rotation).GetComponent<Bullet>();
        bullet.FireMe(offset);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}

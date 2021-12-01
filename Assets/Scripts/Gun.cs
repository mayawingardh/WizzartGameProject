using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Camera cam;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float angle;
    public int ammoCount;

    void Start()
    {
        cam = Camera.main;
        ammoCount = 10;
    }
    public void Update()
    {
        Vector2 mouse = Input.mousePosition;
        Vector2 screenPoint = cam.WorldToScreenPoint(transform.position);
        Vector2 offSet = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);

        angle = Mathf.Atan2(offSet.y, offSet.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        //shoot 
        if (Input.GetMouseButtonDown(0) && ammoCount > 0)
        {
            Fire(offSet);
            ammoCount--;
        }
    }

    public void RefillAmmo(int ammo)
    {
        ammoCount = ammo;
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
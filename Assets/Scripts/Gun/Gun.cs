using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    private Camera cam;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Slider slider;
    public AudioClip reloadClip;
    public AudioClip shooting;
    public AudioSource speaker;

    bool reloading = false;

    public float angle;
    public int ammoCount;

    void Start()
    {
        cam = Camera.main;

        ammoCount = 20;
        slider.maxValue = ammoCount;
    }
    public void Update()
    {
        Vector2 mouse = Input.mousePosition;
        Vector2 screenPoint = cam.WorldToScreenPoint(transform.position);
        Vector2 offSet = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);

        angle = Mathf.Atan2(offSet.y, offSet.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        //shoot 
        if (Input.GetMouseButtonDown(0) && ammoCount > 0 && reloading == false)
        {
            Fire(offSet);
            speaker.PlayOneShot(shooting);
            reloading = true;
            ammoCount--;
            slider.value = ammoCount;
            Invoke("ReloadingGun", 0.2f);

        }

        if (Input.GetKeyDown("r"))

        {
            ammoCount = 20;
            speaker.PlayOneShot(reloadClip);
            reloading = true;
            Invoke("ReloadingGun", 3f); //reloadClip.length
        }
    }

    public void RefillAmmo(int ammo)
    {
        ammoCount = ammo;
        slider.value = ammoCount;
    }

    public void Fire(Vector2 offset)
    {
        Bullet bullet = Instantiate(bulletPrefab, firePoint.position, transform.rotation).GetComponent<Bullet>();
        bullet.FireMe(offset);
    }

    public void ReloadingGun()//lite dåligt namn då det används på flera stallen nu
    {
        reloading = false;
    }
}
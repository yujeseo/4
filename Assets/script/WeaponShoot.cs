using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint; // 총알 발사 위치
    public float fireInterval = 1f;

    public int baseDamage = 10;

    private float timer;

    void Update()
    {

        if (ShopUI.Instance != null && ShopUI.Instance.IsShopOpen)
            return;



        timer += Time.deltaTime;

        if (timer >= fireInterval)
        {
            Shoot();
            timer = 0f;
        }
    }

    void Shoot()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - firePoint.position;

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bullet.GetComponent<Bullet>().SetDirection(direction);
        bullet.GetComponent<Bullet>().damage = baseDamage;

    }

    public void UpgradeDamage(int amount)
    {
        baseDamage += amount;
    }

}

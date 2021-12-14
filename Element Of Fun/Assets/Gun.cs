using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed = 40;
    public GameObject bullet;
    public GameObject bulletFire;
    public GameObject bulletIce;
    public GameObject bulletElectric;
    public Transform barrel;
    public float ShootCooldown = 15f;
    public float CurrentBullet;
    public float lifetime = 10;

    // Update is called once per frame
    private void Update()
    {
        ShootCooldown -= 1;
        if (ShootCooldown <= 0 && CurrentBullet == 0)
        {
            GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
            ShootCooldown = 15f;
            Destroy(spawnedBullet, lifetime);
        }
        else if (ShootCooldown <= 0 && CurrentBullet == 1)
        {
            GameObject spawnedBullet = Instantiate(bulletFire, barrel.position, barrel.rotation);
            spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
            ShootCooldown = 15f;
            Destroy(spawnedBullet, lifetime);
        }
        else if (ShootCooldown <= 0 && CurrentBullet == 2)
        {
            GameObject spawnedBullet = Instantiate(bulletIce, barrel.position, barrel.rotation);
            spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
            ShootCooldown = 15f;
            Destroy(spawnedBullet, lifetime);
        }
        else if (ShootCooldown <= 0 && CurrentBullet == 3)
        {
            GameObject spawnedBullet = Instantiate(bulletElectric, barrel.position, barrel.rotation);
            spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
            ShootCooldown = 15f;
            Destroy(spawnedBullet, lifetime);
        }

    }

    public void SwapToNormal()
    {
        CurrentBullet = 0;
    }
    public void SwapToFire()
    {
        CurrentBullet = 1;
    }
    public void SwapToIce()
    {
        CurrentBullet = 2;
    }
    public void SwapToElectric()
    {
        CurrentBullet = 3;
    }
}

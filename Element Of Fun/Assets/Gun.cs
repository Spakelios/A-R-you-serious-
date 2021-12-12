using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed = 40;
    public GameObject bullet;
    public Transform barrel;
    public float ShootCooldown = 15f;


    // Update is called once per frame
    private void Update()
    {
        ShootCooldown -= 1;
        if (ShootCooldown <= 0)
        {
            GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
            ShootCooldown = 15f;
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

public class SpawnPoint : MonoBehaviour
{
    private float nextSpawnTime;
  
    [SerializeField] public GameObject ducky;

    [SerializeField] private float spawnDelay;


    
    private void Update()
    {
        if (ShouldSpawn())

        {
            Spawn();
        }
    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(ducky, transform.position, transform.rotation);
    }
    
    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}



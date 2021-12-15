using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    public GameObject[] target;
    
    public Transform SpawnPoint;
    public float y1 = -5;
    public float y2 = 5;
    public float x1 = -5;
    public float x2 = 5;
    public float z1 = -5;
    public float z2 = 5;
    public float Lifetime = 2;
    public float waittime = 2;
    // Update is called once per frame
  

    private void Start()
    {
        StartCoroutine(SpawnTarget());
    }

    IEnumerator SpawnTarget()
    {

        var position = new Vector3(Random.Range(x1, x2), Random.Range(y1, y2), Random.Range(z1, z2));
        GameObject Target = Instantiate(target[Random.Range(0, target.Length)], position + SpawnPoint.position, Quaternion.identity);
        Destroy(Target, Lifetime);

        yield return new WaitForSeconds(waittime);
        StartCoroutine(SpawnTarget());
    }
}

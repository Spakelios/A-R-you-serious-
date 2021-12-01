using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject balltothrow;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RH"))
        {
            Debug.Log("itworked");
            Instantiate(balltothrow, new Vector3(-2, 13, -215), Quaternion.identity);
        }
    }
}
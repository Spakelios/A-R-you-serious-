using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieBlock : MonoBehaviour
{
   void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
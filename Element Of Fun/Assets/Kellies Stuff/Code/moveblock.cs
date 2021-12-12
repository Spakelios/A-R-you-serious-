using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveblock : MonoBehaviour
{
    public GameObject prefab;
    Animation anim;

    public void Start()
    {
        GameObject obj = Instantiate(prefab) as GameObject;
        anim = obj.GetComponent<Animation>();
    }
}
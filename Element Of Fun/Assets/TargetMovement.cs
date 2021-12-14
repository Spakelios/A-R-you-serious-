using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{

    public float x = 0;
    public float y = 0;
    public float z = 0;

    void Update()
    {
        // Move the object upward in world space 1 unit/second.
        transform.Translate(Time.deltaTime * x, Time.deltaTime * y, Time.deltaTime * z, Space.World);
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("IceExplosion"))
        {
            x = 0;
            y = 0;
            z = 0;
            
        }
        if (other.gameObject.CompareTag("FireExplosion"))
        {
            Destroy(gameObject);
        }
    }

    void Xspeed()
    {
        x = 0;
    }

    void Yspeed()
    {
        y = 0;
    }

    void Zspeed()
    {
        z = 0;
    }


}

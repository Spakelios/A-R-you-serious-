using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
  public float ExpType;
    public GameObject CollidedObject;
    public SystematicType Script;
    public TargetMovement SpeedScript;

    private void Start()
    {
        //Destroy(gameObject, 60f);
    }
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.CompareTag("System"))
        {
            CollidedObject = other.gameObject;
            if (ExpType == 0)
            {
                Destroy(CollidedObject);
            }

            if (ExpType == 1)
            {
                Script.Type = 2;
                SpeedScript.x = 0;
                SpeedScript.y = 0;
                SpeedScript.z = 0;
            }
        }
    }
}

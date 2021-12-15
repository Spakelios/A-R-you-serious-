using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystematicType : MonoBehaviour
{
    public GameObject FireExplosion;
    public GameObject IceExplosion;
    public GameObject CollidedObject;
    public SystematicType Script;
    public TargetMovement SpeedScript;
    public float Type;

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("System"))
        {
            CollidedObject = collider.gameObject;

            SpeedScript = CollidedObject.GetComponent<TargetMovement>();
            Script = CollidedObject.GetComponent<SystematicType>();

            if (Script.Type == 0)
            {
                Script.Type = Type;
            }
            if (Type == 0)
            {
                Type = Script.Type;
            }
            Script.Contact();


           
        }
    }
   // private void OnTriggerExit(Collider collider)
   // {
   //     if (collider.gameObject.CompareTag("System"))
   //     {
   //         CollidedObject = collider.gameObject;
   //
   //         SpeedScript = CollidedObject.GetComponent<TargetMovement>();
   //         Script = CollidedObject.GetComponent<SystematicType>();
   //
   //        if (Script.Type == 0)
   //        {
   //           Script.Type = Type;
   //        }
   //       if (Type == 0)
   //       {
   //           Type = Script.Type;
   //       }
   //  Script.Contact();


            
    //    }
//    }

    void Contact()
    {
        switch (Type)
        {

            case 0:
                if (Script.Type != 2)
                {

                    Destroy(gameObject);
                    Destroy(CollidedObject);
                } break;

            case 1:
                if (Script.Type != 3)
                {
                    Destroy(CollidedObject);
                }

                break;


            case 2:

                SpeedScript.x = 0;

                SpeedScript.y = 0;

                SpeedScript.z = 0;

                break;


            case 3:
                if (Script.Type == 1)
                {
                    Instantiate(FireExplosion, gameObject.transform);
                }

                if (Script.Type == 2)
                {
                    Instantiate(IceExplosion, gameObject.transform);
                }
                    if (Script.Type == 0) {
                        Destroy(CollidedObject); }
                break;




            default:
                Destroy(CollidedObject);
                break;
        }

        switch (Script.Type)
        {
            case 0:
               if (Type != 2)
                {

                    Destroy(gameObject);
                Destroy(CollidedObject);
                }
            break;
            case 1:
                if (Type != 3)
                {
                    Destroy(CollidedObject);
                }

                break;


            case 2:

                SpeedScript.x = 0;

                SpeedScript.y = 0;

                SpeedScript.z = 0;

                break;


            case 3:
                if (Type == 1)
                {
                    Instantiate(FireExplosion, gameObject.transform);
                    
                }

                if (Type == 2)
                {
                    Instantiate(IceExplosion, gameObject.transform);
                }
                if (Type == 0)
                {
                    Destroy(gameObject);
                }
                break;




            default:
                Destroy(gameObject);
                Destroy(CollidedObject);
                break;
        }

    }

}

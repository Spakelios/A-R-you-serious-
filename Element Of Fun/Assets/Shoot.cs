using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shoot : MonoBehaviour


{
    public float speed = 4.0f;
    public XRController RightHand;
    public InputHelpers.Button ShootButton;
    public float activationThreshold = 0.1f;
    public GameObject bullet;
    public Transform barrel;
    // Update is called once per frame
    void Update()

    {
        if (RightHand)
        {
            RightHand.gameObject.SetActive(CheckIfActivated(RightHand));

            
        }

        

    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, ShootButton, out bool isActivated, activationThreshold);
        
        return isActivated;

       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public int dropValue = 1;
    
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ScoreManager.instance.ChangeScore(dropValue);
        }
    }
}
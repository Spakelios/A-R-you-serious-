using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalManager : MonoBehaviour
{
    public void GotoHub()
    {
        SceneManager.LoadScene("Hub");
    }

    public void GotoDucks()
    {
        SceneManager.LoadScene("Duck");
    }

    public void GotoTarget()
    {
        SceneManager.LoadScene("Target");
    }

    public void GotoBalloon()
    {
        SceneManager.LoadScene("Balloon");
    }
}

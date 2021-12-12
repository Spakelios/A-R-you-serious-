using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI Scoretext;
    public TextMeshProUGUI highscoreText;
    
    private int score = 0;
    private int highscore = 25;
    


    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        Scoretext.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
        

    }

    public void ChangeScore(int dropValue)
    {
        score += dropValue;
        Scoretext.text = score.ToString() + " POINTS";

        if (score >= 25)
        {
            highscoreText.text = "HIGHSCORE " + score.ToString();
        }
    }
}
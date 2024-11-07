using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] TMP_Text Score;
    [SerializeField] TMP_Text HighScore;

    private void Start()
    {
        score();
        highScore();
    }
    private void score()
    {
        Score.text = "Score" + " " + timer.score;
    }
    private void highScore()
    {
        HighScore.text = "HighScore" + " " + PlayerPrefs.GetFloat("HighScore").ToString();
    }
}


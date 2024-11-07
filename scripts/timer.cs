using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float minute, second;
    public TextMeshPro timetext;
    public static float score;
    void Start()
    {
        minute = 0 ;
        second = 0 ;
    }

    void Update()
    {
        second +=Time.deltaTime;
        timetext.text = "0" + minute + ":" + (int)second;
        if (score>PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", score);
        }

        if (second > 59)
        {
            minute++;
            second= 0;
        }
        score=minute*60+second;
    }
}

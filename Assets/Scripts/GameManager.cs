using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public GameObject rain;
    public GameObject endPanel;
    
    public Text totalScoreTxt;
    public Text timeTxt;

    private int totalScore = 0;
    private float totalTime = 30.0f;

    private void Awake()
    {
        instance = this;
        Time.timeScale = 1.0f;
    }

    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);
    }
    
    void Update()
    {
        if (totalTime > 0f)
        {
            totalTime -= Time.deltaTime;
        }
        else
        {
            totalTime = 0f;
            endPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        
        timeTxt.text = totalTime.ToString("N2");
    }

    public void MakeRain()
    {
        Instantiate(rain);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        totalScoreTxt.text = totalScore.ToString();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public GameObject rain;
    public Text totalScoreTxt;

    private int totalScore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);
    }
    
    void Update()
    {
        
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

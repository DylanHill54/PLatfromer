using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public float timeRemaining = 400;
    public bool timerIsRunning = false;
    private void Start()
    {
        timer.text = timeRemaining.ToString("0");
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timer.text = timeRemaining.ToString("0");
            }
            else
            {
                timeRemaining = 0;
                timer.text = timeRemaining.ToString("0");
                timerIsRunning = false;
            }
        }
    }
}


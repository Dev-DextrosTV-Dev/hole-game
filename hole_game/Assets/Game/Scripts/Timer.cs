using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private float currentTime = 0f;
    public int startMinutes = 60;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startMinutes * 60;
    }

    // Update is called once per frame
    void Update()
    {
        ShowTimer();
    }
    
    void ShowTimer()
    {
        currentTime = currentTime + Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        
        timerText.text = time.Minutes.ToString("00") + ":" + time.Seconds.ToString("00");
    }
}

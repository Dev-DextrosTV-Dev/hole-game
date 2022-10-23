using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    int score = 0;
    public TMP_Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowScore();
    }
    
    public void AddScore()
    {
        score += 1;
    }
    
    void ShowScore()
    {
        // Makes the Float Score into a String and shows it in the HUD
        scoreText.text = score.ToString("0");
    }
}

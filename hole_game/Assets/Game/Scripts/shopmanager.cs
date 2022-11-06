using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using Color = UnityEngine.Color;

public class shopmanager : MonoBehaviour
{
    int themeNumber;
    public TMP_Text themeNumberText;

    // Update is called once per frame
    void Update()
    {
        // Setting the theme
        switch (themeNumber)
        {
            // less than 1
            case <= 0:
                themeNumber = 1;
                break;

            // basic Design
            case 1:
                Player.playerColor = Color.black;
                FinishHole.holeColor = Color.blue;
                GameCamera.camColor = Color.gray;
                break;

            //
            case 2:
                Player.playerColor = Color.white;
                FinishHole.holeColor = Color.red;
                GameCamera.camColor = Color.black;
                break;

            //
            case 3:
                Player.playerColor = Color.green;
                FinishHole.holeColor = Color.gray;
                GameCamera.camColor = Color.red;
                break;

            // more than 3
            case >= 4:
                themeNumber = 3;
                break;

        }

        // Shows the number as text
        themeNumberText.text = themeNumber.ToString("0");
    }

    public void OnThemePlus()
    {
        themeNumber++;
    }

    public void OnThemeMinus()
    {
        themeNumber--;
    }
}

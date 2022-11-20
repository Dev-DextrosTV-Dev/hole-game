using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using Color = UnityEngine.Color;

public class shopmanager : MonoBehaviour
{
    int themeNumber = 1;
    public TMP_Text themeNumberText;

    public GameObject lockImage;

    // Theme unlocks
    bool firstThemeUnlocked = true;
    bool secondThemeUnlocked = false;
    bool thirdThemeUnlocked = false;  


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
                themeColors.firstThemeColorImageColor = new Color(0.2412602f, 0.2466429f, 0.254717f, 1f);
                themeColors.secondaryThemeColorImageColor = new Color(0.3245283f, 0.825968f, 1f, 1f);

                if(firstThemeUnlocked == true)
                {

                    lockImage.SetActive(false);
                }
                else
                {
                    lockImage.SetActive(true);
                }
                break;

            //
            case 2:
                themeColors.firstThemeColorImageColor = new Color(0.2412602f, 0.2466429f, 0.254717f, 1f);
                themeColors.secondaryThemeColorImageColor = new Color(0.3245283f, 0.825968f, 1f, 1f);

                if(secondThemeUnlocked == true)
                {

                    lockImage.SetActive(false);
                }
                else
                {
                    lockImage.SetActive(true);
                }
                break;

            //
            case 3:  
                themeColors.firstThemeColorImageColor = new Color(0.2412602f, 0.2466429f, 0.254717f, 1f);
                themeColors.secondaryThemeColorImageColor = new Color(0.3245283f, 0.825968f, 1f, 1f);

                if(thirdThemeUnlocked == true)
                {

                    lockImage.SetActive(false);
                }
                else
                {
                    lockImage.SetActive(true);
                }
                break;

            // more than 3
            case >= 4:
                themeNumber = 3;
                break;

        }

        themeNumberText.text = themeNumber.ToString();
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class themeColors : MonoBehaviour
{
    public RawImage firstThemeColorImage;
    public static Color firstThemeColorImageColor;

    public RawImage secondaryThemeColorImage;
    public static Color secondaryThemeColorImageColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        firstThemeColorImage.color = firstThemeColorImageColor;
        secondaryThemeColorImage.color = secondaryThemeColorImageColor;
    }
}

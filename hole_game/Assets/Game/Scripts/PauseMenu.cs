using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public void OnPause()
    {
        Time.timeScale = 0;
    }
    
    public void OnContinue()
    {
        Time.timeScale = 1;
    }
}

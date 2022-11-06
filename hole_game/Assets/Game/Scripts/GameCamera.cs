using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    public Camera cam;
    public static Color camColor;


    // Start is called before the first frame update
    void Start()
    {
        cam.backgroundColor = camColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

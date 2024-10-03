using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRUIP;

public class ColorSchemeVR : MonoBehaviour
{
    // Start is called before the first frame update

    Color primary = new Color(0.5f, 0.7f, 1f); 
    Color secondary = new Color(1f, 1f, 1f); 
    Color third = new Color(0.7f, 0.9f, 1f); 
    Color fourth = new Color(0.2f, 0.5f, 1f); 
    


    void Awake()
    {
        ColorTheme theme = new ColorTheme(primary, secondary, third, fourth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

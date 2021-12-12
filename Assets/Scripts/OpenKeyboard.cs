using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenKeyboard : MonoBehaviour
{
    TouchScreenKeyboard klavye;
    public Text txt;
    string textt;

    public void UpKeyboard()
    {
        klavye = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default); 
    }

    
    void Update()
    {
        if (TouchScreenKeyboard.visible == false && klavye != null)
        {
            textt = klavye.text;
            txt.text = "";
            klavye = null;
        }
    }
}

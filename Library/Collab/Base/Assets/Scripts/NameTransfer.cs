using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{
    public string charcterName;
    public GameObject InputArea;
    public GameObject textDisplay;
    public GameObject DownText;

    public void StoreName()
    {
        charcterName = InputArea.GetComponent<Text>().text;
        DownText.SetActive(true);
        textDisplay.GetComponent<Text>().text = "Your Character Name is " + charcterName + ".";     
    }
    public void GoButton()
    {
        SceneManager.LoadScene(1);
    }
}

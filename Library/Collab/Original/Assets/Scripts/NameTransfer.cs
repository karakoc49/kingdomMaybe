using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{
    public string characterName;
    public GameObject InputArea;
    public GameObject textDisplay;
    public GameObject DownText;

    void OnGUI()
    {
        characterName = GUI.TextField(new Rect(190, 150, 640, 110), characterName, 10);
    }

    public void ShowName()
    {
        DownText.SetActive(true);
        textDisplay.GetComponent<Text>().text = "Your Character Name is " + characterName + ".";
    }
    public void GoButton()
    {
        SceneManager.LoadScene(1);
    }
}

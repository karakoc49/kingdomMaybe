using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject PlayMenu;
    public GameObject SettingsMenu;
    public GameObject NameCreate;
    public void PlayButton()
    {
        MainMenu.SetActive(false);
        PlayMenu.SetActive(true);
    }

    public void SettingsButton()
    {
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }
    public void MenuButton()
    {
        MainMenu.SetActive(true);
        PlayMenu.SetActive(false);
        SettingsMenu.SetActive(false);
    }
    public void NewGameButton()
    {
        PlayMenu.SetActive(false);
        NameCreate.SetActive(true);
    }
    public void ContinueButton()
    {
        SceneManager.LoadScene(null);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}

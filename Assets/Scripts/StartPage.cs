using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartPage : MonoBehaviour
{
    public Button StartGameButton;
    public Button ResumeGameButton;
    public Button QuitGameButton;
    public GameObject MainMenuPanel;

    public void StartButton()
    {
        //add the code which is started the game
        MainMenuPanel.SetActive(false);
    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        MainMenuPanel.SetActive(false); // continue the game 
        StartGameButton.gameObject.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}

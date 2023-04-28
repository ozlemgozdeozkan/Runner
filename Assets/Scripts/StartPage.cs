using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartPage : MonoBehaviour
{
    public Button StartGameButton;
    public Button ResumeGameButton;
    public Button QuitGameButton;
    public GameObject MainMenuPanel;


    public void StartButton()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(1);
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

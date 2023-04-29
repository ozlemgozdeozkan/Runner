using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartPage : MonoBehaviour
{
    public Button StartGameButton;
    public Button QuitGameButton;
    public GameObject MainMenuPanel;

    public void StartButton()
    {       
        SceneManager.LoadScene(1);
    }  
    public void QuitButton()
    {
        Application.Quit();
    }
}

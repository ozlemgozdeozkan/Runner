using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResumePanel : MonoBehaviour
{
    public Button PauseGameButton;
    public Button ResumeGameButton;
    public Button QuitGameButton;
    public GameObject MainPanel;
    public void PauseButton()
    {
        Time.timeScale = 0;
        MainPanel.SetActive(true);
    }
    public void ResumeButton()
    {
        MainPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Button PauseButton;
    public GameObject MainMenuPanel;
    public Button StartGameButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseGameButton()
    {
      
        MainMenuPanel.SetActive(true);
        StartGameButton.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
}

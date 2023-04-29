using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UITextsAndSprites[] uiTextsAndSprites;
    [SerializeField] private GameObject[] rewards;
    private ScorePanel _scorePanel;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += SetComponents;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= SetComponents;
    }

    void Update()
    {
        ChangeRewardBasedOnTime();
    }

    private void ChangeRewardBasedOnTime()
    {
        float desiredSecond = 20.0f;
        int currentTextsAndSprites = 0;

        for (int i = 0; i < desiredSecond; i++)
        {
            if (i >= desiredSecond)
            {
                for (int j = 0; j < rewards.Length; j++)
                {
                    rewards[j] = uiTextsAndSprites[i].currentRewardObject;
                }
                currentTextsAndSprites++;
                _scorePanel.ChangeRewardType(uiTextsAndSprites[currentTextsAndSprites]);
                i = 0;
            }
        }
    }
    
    private void SetComponents(Scene scene, LoadSceneMode loadSceneMode)
    {
        _scorePanel = GameObject.Find("ScorePanel").GetComponent<ScorePanel>(); //To call another script from another object?
    }
}

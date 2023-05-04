using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScorePanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Image _goodImage;
    [SerializeField] private Image _badImage;
    public TextMeshProUGUI goodText;
    public TextMeshProUGUI badText;

    private void Start()
    {
        ResetScore();
    }
    void Update()
    {
        scoreText.text = $"SCORE: {ScoreManager.Instance.TotalScore}";
        scoreText.color = Color.red;
        if(ScoreManager.Instance.TotalScore < 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void ChangeRewardType(UITextsAndSprites uiTextsAndSprites)
    {
        goodText.text = uiTextsAndSprites.goodText;
        badText.text = uiTextsAndSprites.badText;
        _goodImage.sprite = uiTextsAndSprites.goodSprites;
        _badImage.sprite = uiTextsAndSprites.badSprites;
    }
    public void ResetScore()
    {
        ScoreManager.Instance.TotalScore = 0;
    }
}
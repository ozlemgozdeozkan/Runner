using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScorePanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Image _goodImage;
    [SerializeField] private Image _badImage;
    public TextMeshProUGUI goodText;
    public TextMeshProUGUI badText;

    void Update()
    {
        scoreText.text = $"SCORE: {ScoreManager.Instance.TotalScore}";
        scoreText.color = Color.red;
    }

    public void ChangeRewardType(UITextsAndSprites uiTextsAndSprites)
    {
        goodText.text = uiTextsAndSprites.goodText;
        badText.text = uiTextsAndSprites.badText;
        _goodImage.sprite = uiTextsAndSprites.goodSprites;
        _badImage.sprite = uiTextsAndSprites.badSprites;
    }
}
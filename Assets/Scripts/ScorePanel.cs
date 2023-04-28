using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScorePanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    void Start()
    {
        
    }

    
    void Update()
    {
        scoreText.text = $"Score: {ScoreManager.Instance.TotalScore}";  
    }
}

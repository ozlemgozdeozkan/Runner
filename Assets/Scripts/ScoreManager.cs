using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // -------------------------------- FIELDS --------------------------------
    [Header("SINGLETON")]
    private static ScoreManager _instance;
    public static ScoreManager Instance { get { return _instance; } }
   
    public float TotalScore { get; set; }


    // ------------------------ UNITY BUILT-IN METHODS ------------------------
    private void Awake()
    {
        InitializeSingleton();
    }


    // ------------------------ CUSTOM PRIVATE METHODS ------------------------
    private void InitializeSingleton()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // ------------------------ CUSTOM PUBLIC METHODS -------------------------
    public void AddScore(float scoreToAdd)
    {
        TotalScore += scoreToAdd;
    }

    public void RemoveScore(float scoreToRemove)
    {
        TotalScore -= scoreToRemove;
    }

}


using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UITextsAndSprites[] uiTextsAndSprites;
    [SerializeField] private Transform player;
    private ScorePanel _scorePanel;
    private float _elapsedTimeToSpawnReward = 0.0f;
    public float _desiredSecondToSpawnRewards = 3.5f;
    private int _currentReward = 0;
    private float _elapsedTimeToChangeReward = 0.0f;
    public float _desiredSecondToChangeReward = 20.0f;


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
        RewardSpawnTimer();
        ChangeRewardBasedOnTime();
    }

    private void ChangeRewardBasedOnTime()
    {
        _elapsedTimeToChangeReward += Time.deltaTime;

        if (_elapsedTimeToChangeReward >= _desiredSecondToChangeReward)
        {
            _currentReward++;
            _scorePanel.ChangeRewardType(uiTextsAndSprites[_currentReward]);
            _elapsedTimeToChangeReward = 0.0f;
        }
    }

    private void RewardSpawnTimer()
    {
        _elapsedTimeToSpawnReward += Time.deltaTime;

        if (_elapsedTimeToSpawnReward >= _desiredSecondToSpawnRewards)
        {
            SpawnReward(uiTextsAndSprites[_currentReward].currentRewardObject);
            SpawnReward(uiTextsAndSprites[_currentReward].currentBadObject);

            _elapsedTimeToSpawnReward = 0.0f;
        }
    }

    private void SpawnReward(GameObject gameObject)
    {
        float randomXRange = Random.Range(-2.35f, 2.35f);
        float randomZOffset = Random.Range(10f, 30f);

        Vector3 spawnPosition = new Vector3(randomXRange, 1.3f, player.position.z + randomZOffset);

        Instantiate(gameObject, spawnPosition, Quaternion.identity);
    }

    private void SetComponents(Scene scene, LoadSceneMode loadSceneMode)
    {
        _scorePanel = GameObject.Find("ScorePanel").GetComponent<ScorePanel>(); //To call another script from another object?
    }
}
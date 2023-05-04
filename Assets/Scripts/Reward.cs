using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    [SerializeField] private RewardTypes rewardType;
    private void Start()
    {
        Destroy(gameObject, 10f);
    }

    private void Update()
    {
        // oyuncu belirli bir noktadan daha uzaga gittiginde (REWARD'un) pozisyonunu destroy et
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);

            switch (rewardType)
            {
                case RewardTypes.GOOD_IRON:
                    ScoreManager.Instance.AddScore(10);
                    break;
                case RewardTypes.BAD_IRON:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                case RewardTypes.GOOD_COIN:
                    ScoreManager.Instance.AddScore(10);
                    break;
                case RewardTypes.BAD_COIN:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                case RewardTypes.GOOD_FLOWER:
                    ScoreManager.Instance.AddScore(10);
                    break;
                case RewardTypes.BAD_FLOWER:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                case RewardTypes.GOOD_SUIT:
                    ScoreManager.Instance.AddScore(10);
                    break;
                case RewardTypes.BAD_SUIT:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                case RewardTypes.GOOD_ROLLINGPIN:
                    ScoreManager.Instance.AddScore(10);
                    break;
                case RewardTypes.BAD_ROLLINGPIN:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                case RewardTypes.GOOD_HELMET:
                    ScoreManager.Instance.AddScore(10);
                    break;
                case RewardTypes.BAD_HELMET:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                case RewardTypes.GOOD_CRY:
                    ScoreManager.Instance.AddScore(10);
                    break;
                case RewardTypes.BAD_CRY:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                case RewardTypes.GOOD_PLIERS:
                    ScoreManager.Instance.AddScore(10);
                    break;
                case RewardTypes.BAD_PLIERS:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                case RewardTypes.GOOD_RING:
                    ScoreManager.Instance.AddScore(10);
                    break;
                case RewardTypes.BAD_RING:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                case RewardTypes.GOOD_VANISH:
                    ScoreManager.Instance.AddScore(10);
                    break;
                case RewardTypes.BAD_VANISH:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                case RewardTypes.GOOD_STEERINGWHEEL:
                    ScoreManager.Instance.AddScore(10);
                    break;
                case RewardTypes.BAD_STEERINGWHEEL:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                default:
                    break;
            }
        }
    }
}

public enum RewardTypes
{
    GOOD_IRON, BAD_IRON, GOOD_COIN, BAD_COIN, GOOD_FLOWER, BAD_FLOWER, GOOD_SUIT, BAD_SUIT, GOOD_ROLLINGPIN, BAD_ROLLINGPIN, GOOD_HELMET,
    BAD_HELMET, GOOD_CRY, BAD_CRY, GOOD_PLIERS, BAD_PLIERS, GOOD_RING, BAD_RING, GOOD_VANISH, BAD_VANISH, GOOD_STEERINGWHEEL, BAD_STEERINGWHEEL
}

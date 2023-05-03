using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    [SerializeField] private RewardTypes rewardType;

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

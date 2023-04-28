using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    [SerializeField] private RewardTypes rewardType;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (rewardType)
            {
                case RewardTypes.GOOD_IRON:
                    ScoreManager.Instance.AddScore(10);
                    Destroy(gameObject);
                    break;
                case RewardTypes.BAD_IRON:
                    ScoreManager.Instance.RemoveScore(5);
                    break;
                case RewardTypes.GOOD_COIN:
                    break;
                case RewardTypes.BAD_COIN:
                    break;
                default:
                    break;
            }
        }
    }

}
public enum RewardTypes
{
    GOOD_IRON, BAD_IRON, GOOD_COIN, BAD_COIN
}

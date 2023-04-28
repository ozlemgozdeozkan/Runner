using UnityEngine;
using TMPro;

public class GroundBuild : MonoBehaviour
{
    public static GroundBuild Instance { get; private set; }

    public TextMeshProUGUI CoinText = null;

    public int Coin { get;}

    //Instance = Singleton Design Pattern
    //{get; private set;} Encapsulation

    [SerializeField] private GameObject last_ground;

    private Vector3 _lastGroundPosition;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        for(int i = 0; i < 15; i++)
            Create_Ground();
    }

    public void CreateGroundLogic() => Create_Ground();

    private void Create_Ground()
    {
        Vector3 offset = Vector3.forward * 3.1f;
        GameObject spawnedGround = Instantiate(last_ground, _lastGroundPosition + offset , last_ground.transform.rotation);
        _lastGroundPosition = spawnedGround.transform.position;              
    }
}
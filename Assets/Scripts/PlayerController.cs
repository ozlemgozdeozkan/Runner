using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public GameObject MainMenuPanel;
    //public GroundBuild createGround;

    //Singleton Design Patter

    [SerializeField] private float _moveSpeed = 0.00f;

    [SerializeField, Range(0.00f, 5.00f)] private float _touchSensitivity = 0.00f;

    [SerializeField] private float _clampPositionX = 0.00f;

    private float _lastMousePositionX = 0.00f;

    private float _moveDirectionX = 0.00f;

    private void Start()
    {
       
    }
    private void Update()
    {
        MoveForward();

        ListenInputs();

        PlayerMoveSwerve();
    }

    private void ListenInputs()
    {
        if (Input.GetMouseButtonDown(0))
            _lastMousePositionX = Input.mousePosition.x;

        if (Input.GetMouseButton(0))
        {
            _moveDirectionX = (Input.mousePosition.x - _lastMousePositionX);
            _lastMousePositionX = Input.mousePosition.x;
        }

        if (Input.GetMouseButtonUp(0))
            _moveDirectionX = 0.00f;
    }

    private void PlayerMoveSwerve()
    {
        float _playerMoveX = Time.deltaTime * _touchSensitivity * _moveDirectionX;

        Vector3 _direction = new(_playerMoveX, 0, 0);

        transform.Translate(_direction);

        Vector3 _clampedPosition = transform.position;

        _clampedPosition.x = Mathf.Clamp(_clampedPosition.x , -_clampPositionX , _clampPositionX);

        transform.position = _clampedPosition;
    }

    private void MoveForward() => transform.Translate(Time.deltaTime * _moveSpeed * Vector3.forward);


    private void OnCollisionExit(Collision collision)//collision: ��k�� yapt���m�z nesnedir. ek zemin getirmek i�in
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(Remove(collision.gameObject));
            GroundBuild.Instance.CreateGroundLogic();
        }
    }
    private IEnumerator Remove(GameObject obj)
    {
        yield return new WaitForSeconds(0.2f);//g�rsellik i�in
        obj.AddComponent<Rigidbody>();//Zemin d��medeki yer�ekimi i�lemi

        yield return new WaitForSeconds(1f);//optimizasyon i�in
        Destroy(obj.gameObject);
    }
}
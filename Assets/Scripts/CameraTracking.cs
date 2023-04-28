using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    [SerializeField] private Transform _target = null;

    [SerializeField] private float _trackSpeed = 0.00f;

    private Vector3 _offset = Vector3.zero;

    private void Awake()
    {
        _offset = transform.position - _target.position;
    }

    private void LateUpdate()
    {
        if (!_target)// !target = target == null
            return;

        transform.position = Vector3.Lerp(transform.position , _target.position + _offset , Time.deltaTime * _trackSpeed);
    }
}
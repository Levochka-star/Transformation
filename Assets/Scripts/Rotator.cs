using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _center;
    
    private Vector3 _localCenter;

    private void Start()
    {
        _localCenter = transform.position - _center.position;
    }

    private void Update()
    {
        transform.position = _localCenter + _center.position;

        transform.RotateAround(_center.position, Vector3.down, _speed * Time.deltaTime);

        _localCenter = transform.position - _center.position;
    }
}

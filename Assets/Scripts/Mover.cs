using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Start()
    {

    }

    private void Update()
    {
        var position = transform.position;

        position.x +=_speed * Time.deltaTime;

        transform.position = position;
    }
}

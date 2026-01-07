using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 position = transform.position;

        position.x +=_speed * Time.deltaTime;

        transform.position = position;
    }
}

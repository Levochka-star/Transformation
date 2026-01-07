using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speedIncreaseRateSize;

    private void Update()
    {
        var nextScale  = transform.localScale;

        nextScale += Vector3.one * _speedIncreaseRateSize * Time.deltaTime;

        transform.localScale = nextScale;
    }
}

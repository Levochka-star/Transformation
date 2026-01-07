using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _rateIncrease;

    private void Update()
    {
        transform.localScale += Vector3.one * _rateIncrease * Time.deltaTime;
    }
}

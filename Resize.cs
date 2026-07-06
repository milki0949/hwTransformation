using UnityEngine;

public class Resize : MonoBehaviour
{
    [SerializeField] private float _growthSpeed = 0f;

    private void Update()
    {
        transform.localScale += Vector3.one * _growthSpeed * Time.deltaTime;
    }
}

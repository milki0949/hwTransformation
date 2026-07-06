using UnityEngine;

public class Size : MonoBehaviour
{
    [SerializeField] private float _growthSpeed = 0f;

    void Update()
    {
        transform.localScale += Vector3.one * _growthSpeed * Time.deltaTime;
    }
}

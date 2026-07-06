using UnityEngine;

public class Turn : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 0f;

    void Update()
    {
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
    }
}

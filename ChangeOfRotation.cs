using UnityEngine;

public class ChangeOfRotation : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 0f;

    private void Update()
    {
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
    }
}

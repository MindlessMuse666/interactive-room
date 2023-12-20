using UnityEngine;

namespace Controllers
{
    public class RotationController : MonoBehaviour
    {
        [SerializeField] private float _minY = -60;
        [SerializeField] private float _maxY = 60;

        private float _moveX;
        private float _moveY;

        private void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void LateUpdate()
        {
            _moveX += Input.GetAxis("Mouse X");
            _moveY -= Input.GetAxis("Mouse Y");

            _moveY = Mathf.Clamp(_moveY, _minY, _maxY);

            transform.rotation = Quaternion.Euler(_moveY, _moveX, 0);
        }
    }
}
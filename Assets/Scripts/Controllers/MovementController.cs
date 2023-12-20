using UnityEngine;

namespace Controllers
{
    public class MovementController : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;

        private CharacterController _characterController;

        private void Start()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            var verticalInput = Input.GetAxis("Vertical");
            var horizontalInput = Input.GetAxis("Horizontal");

            var inputDirection = new Vector3(horizontalInput, 0, verticalInput);
            var direction = transform.TransformDirection(inputDirection);

            _characterController.SimpleMove(direction * _speed);
        }
    }
}
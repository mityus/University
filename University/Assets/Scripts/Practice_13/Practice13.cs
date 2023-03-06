using System;
using Common;
using UnityEngine;

namespace Practice_13
{
    public class Practice13 : MonoBehaviour
    {
        [SerializeField] private float speedJump;
        [SerializeField] private float speedMovement;
        
        private bool _isJump;

        private Rigidbody _rigidbody;

        private void Start()
        {
            _isJump = false;

            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Move();

            if (Input.GetKeyDown(InputConfig.JumpKey))
            {
                Jump();
            }
        }

        private void Move()
        {
            transform.Translate(Input.GetAxis("Horizontal") * speedMovement * Time.deltaTime, 0, 0);

            transform.Translate(0, 0, Input.GetAxis("Vertical") * speedMovement * Time.deltaTime);
        }

        private void Jump()
        {
            if (!_isJump)
            {
                _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, speedJump, _rigidbody.velocity.z);
                _isJump = true;
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.name == "Ground") _isJump = false;
        }
    }
}

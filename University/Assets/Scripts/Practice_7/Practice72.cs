using System;
using UnityEngine;

namespace Practice_7
{
    public class Practice72 : MonoBehaviour
    {
    
        [SerializeField] private Vector3 speedMovement;

        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            _rigidbody.velocity = speedMovement * Time.deltaTime;
        }
    }
}

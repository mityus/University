using System;
using Common;
using UnityEngine;

namespace Practice_6
{
    public class Practice61 : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if(Input.GetKeyUp(InputConfig.JumpKey)) _rigidbody.AddForce(0, 200, 0);
        }
    }
}

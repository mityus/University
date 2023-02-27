using System;
using UnityEngine;

namespace Practice_6
{
    public class Practice64 : MonoBehaviour
    {
        private Renderer _renderer;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _renderer = GetComponent<Renderer>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnMouseDown()
        {
            Debug.Log(name);
            Debug.Log(transform.position);
            Debug.Log(_renderer.material.color);
            Debug.Log(_rigidbody.mass);
        }
    }
}

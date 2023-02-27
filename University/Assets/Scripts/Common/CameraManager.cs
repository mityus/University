using System;
using UnityEngine;

namespace Common
{
    public class CameraManager : MonoBehaviour
    {
        [SerializeField] private Transform target;

        [Space] [SerializeField] private Vector3 offset;

        private void Update()
        {
            MoveCamera();
        }

        private void MoveCamera()
        {
            transform.position = target.position + offset;
        }
    }
}

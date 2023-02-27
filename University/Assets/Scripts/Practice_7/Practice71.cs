using System;
using UnityEngine;

namespace Practice_7
{
    public class Practice71 : MonoBehaviour
    {
        [SerializeField] private float speedMovement;

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            transform.Translate(0, 0, -speedMovement * Time.deltaTime);
        }
    }
}

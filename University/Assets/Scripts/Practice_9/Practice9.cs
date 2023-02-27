using System;
using UnityEngine;

namespace Practice_9
{
    public class Practice9 : MonoBehaviour
    {
        private AudioSource _audioSource;

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        private void OnTriggerEnter(Collider other)
        {
            _audioSource.Play();
        }
    }
}

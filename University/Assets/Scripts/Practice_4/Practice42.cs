using System;
using UnityEngine;

namespace Practice_4
{
    public class Practice42 : MonoBehaviour
    {
        [SerializeField] private string tagGameObject;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag(tagGameObject)) Destroy(gameObject);
        }
    }
}

using System;
using UnityEngine;

namespace Practice_4
{
    public class Practice41 : MonoBehaviour
    {
        [SerializeField] private string tagGameObject;
        
        private void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.CompareTag(tagGameObject)) Destroy(gameObject);
        }
    }
}

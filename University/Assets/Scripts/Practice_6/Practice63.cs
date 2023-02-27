using System;
using UnityEngine;

namespace Practice_6
{
    public class Practice63 : MonoBehaviour
    {
        [SerializeField] private Material materialEnter;
        [SerializeField] private Material materialExit;

        private MeshRenderer _meshRenderer;
        
        private void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        private void OnMouseEnter()
        {
            _meshRenderer.material = materialEnter;
        }

        private void OnMouseExit()
        {
            _meshRenderer.material = materialExit;
        }
    }
}

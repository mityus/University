using System;
using Common;
using UnityEngine;

namespace Practice_6
{
    public class Practice62 : MonoBehaviour
    {
        [SerializeField] private Material newMaterial;

        private MeshRenderer _meshRenderer;

        private void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        private void Update()
        {
            if (Input.GetKeyUp(InputConfig.ColorKey)) _meshRenderer.material = newMaterial;
        }
    }
}

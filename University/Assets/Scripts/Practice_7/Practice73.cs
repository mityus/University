using System;
using Common;
using UnityEngine;

namespace Practice_7
{
    public class Practice73 : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        private void Update()
        {
            if (Input.GetKeyDown(InputConfig.CreateObjectKey))
                Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}

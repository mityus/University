using System;
using Common;
using UnityEngine;

namespace Practice_8
{
    public class Practice8 : MonoBehaviour
    {
        private Animator _animator;
        
        private static readonly int IsJump = Animator.StringToHash("isJump");

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if(Input.GetKeyDown(InputConfig.ChangeAnimationKey)) _animator.SetTrigger(IsJump);
        }
    }
}

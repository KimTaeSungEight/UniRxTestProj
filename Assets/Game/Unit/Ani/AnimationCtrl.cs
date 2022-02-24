using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unit.Ani
{
    public class AnimationCtrl : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public void PlayAni(AnimationEnum animationEnum)
        {
            _animator.SetInteger("State", (int)animationEnum);
        }

        public float GetCurAniTime()
        {
            return _animator.GetCurrentAnimatorStateInfo(0).normalizedTime % 1;
        }

        public int GetCurAni()
        {
            return _animator.GetInteger("State");
        }

        public void SetAnimationTimeScale(float timeScale)
        {
            _animator.speed = timeScale; 
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KimbaUnit.Ani
{
    public class AnimationCtrl : MonoBehaviour, IAnimationCtrl
    {
        [SerializeField] private Animator _animator;

        public void SetAniState(AnimationEnum animationEnum)
        {
            _animator.SetInteger("State", (int)animationEnum);
        }

        public void SetAniFrontOrBack(bool isfrontOrBack)
        {
            _animator.SetBool("Front", isfrontOrBack);
        }

        public float GetCurAniTime()
        {
            return _animator.GetCurrentAnimatorStateInfo(0).normalizedTime % 1;
        }

        public int GetCurAni()
        {
            return _animator.GetInteger("State");
        }

        public void SetAnimationmTimeScale(float timeScale)
        {
            _animator.speed = timeScale;
        }
    }
}
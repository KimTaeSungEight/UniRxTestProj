using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unit.Ani
{
    public interface IAnimationCtrl
    {
        void PlayAni(AnimationEnum animationEnum);

        float GetCurAniTime();

        int GetCurAni();

        void SetAnimationmTimeScale(float timeScale);

    }
}

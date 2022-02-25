using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KimbaUnit.Ani
{
    public interface IAnimationCtrl
    {
        void SetAniState(AnimationEnum animationEnum);
        void SetAniFrontOrBack(bool isfrontOrBack);

        float GetCurAniTime();

        int GetCurAni();

        void SetAnimationmTimeScale(float timeScale);

    }
}

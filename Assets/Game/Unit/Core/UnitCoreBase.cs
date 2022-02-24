using System.Collections;
using System.Collections.Generic;
using UniRx;
using Unit.Ani;
using Unit.Stat;
using UnityEngine;

namespace Unit.Core
{
    public class UnitCoreBase : MonoBehaviour, IUnitCore
    {
        [SerializeField]
        private AnimationCtrl _animationCtrl;
        [SerializeField]
        private UnitMovement _movement;
        private StatCtrl statCtrl = new StatCtrl();

        private Subject<UniRx.Unit> UnitDeadAsync;

        public ISubject<UniRx.Unit> UnitDeadSubject => UnitDeadAsync;

        public IReadOnlyReactiveProperty<float> Hp => statCtrl.HpProperty;

        public UnitStat UnitStat => statCtrl.UnitStat;

        public int GetCurAni()
        {
            return _animationCtrl.GetCurAni();
        }

        public float GetCurAniTime()
        {
            return _animationCtrl.GetCurAniTime();
        }

        public void PlayAni(AnimationEnum animationEnum)
        {
            _animationCtrl.PlayAni(animationEnum);
        }

        public void SetAnimationmTimeScale(float timeScale)
        {
            _animationCtrl.SetAnimationTimeScale(timeScale);
        }

        public void HandleHp(float changeHp)
        {
            statCtrl.HandleHp(changeHp);
        }

        public void Move()
        {
            _movement.Move();
        }


    }
}
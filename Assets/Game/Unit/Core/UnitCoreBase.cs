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
        private StatCtrl _statCtrl = new StatCtrl();

        protected Subject<UniRx.Unit> UnitDeadAsync;
        protected ReactiveProperty<bool> _isMoveAble;

        public ISubject<UniRx.Unit> UnitDeadSubject => UnitDeadAsync;

        public IReadOnlyReactiveProperty<float> Hp => _statCtrl.HpProperty;

        public UnitStat UnitStat => _statCtrl.UnitStat;

        public IReadOnlyReactiveProperty<bool> IsMoveAble => _isMoveAble;

        private void Awake()
        {
            _statCtrl.Init(new UnitStat());   
        }

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
            _statCtrl.HandleHp(changeHp);
        }

        public void Move()
        {
            _movement.Move();
        }


    }
}
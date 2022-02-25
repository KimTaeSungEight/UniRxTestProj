using KimbaUnit.Ani;
using KimbaUnit.Core;
using KimbaUnit.Movement;
using KimbaUnit.Stat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KimbaUnit.Moderator
{
    public class UnitModerator : MonoBehaviour, IUnitModerator
    {
        private IUnitMovement _movement;
        public IUnitMovement Movement => _movement;

        private IAnimationCtrl _animation;
        public IAnimationCtrl Animation => _animation;

        private IUnitCore _unit;
        public IUnitCore Unit => _unit;

        private IStatCtrl _stat;
        public IStatCtrl Stat => _stat;

        void Start()
        {
            InitUnitInterface();
        }

        private void InitUnitInterface()
        {
            _movement = GetComponentInChildren<IUnitMovement>();
            _animation = GetComponentInChildren<IAnimationCtrl>();
            _unit = GetComponentInChildren<IUnitCore>();
            _stat = GetComponentInChildren<IStatCtrl>();
        }
    }
}
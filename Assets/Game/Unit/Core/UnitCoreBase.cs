using System.Collections;
using System.Collections.Generic;
using UniRx;
using KimbaUnit.Ani;
using KimbaUnit.Stat;
using UnityEngine;
using KimbaUnit.Moderator;

namespace KimbaUnit.Core
{
    public class UnitCoreBase : MonoBehaviour, IUnitCore
    {
        private Subject<Unit> _unitDeadAsync = new Subject<Unit>();
        public ISubject<Unit> UnitDeadSubject => _unitDeadAsync;

        private IUnitModerator _unitProvider;
        public IUnitModerator UnitProvider => _unitProvider;

        private void Start()
        {
            Init();
        }

        protected virtual void Init()
        {
            _unitProvider = GetComponentInParent<IUnitModerator>();
        }
    }
}
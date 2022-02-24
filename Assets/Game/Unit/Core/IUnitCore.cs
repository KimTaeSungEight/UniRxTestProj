using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

namespace Unit.Core
{
    public interface IUnitCore : IUnitMovement, Stat.IStatCtrl, Ani.IAnimationCtrl
    {
        ISubject<UniRx.Unit> UnitDeadSubject { get; }   
    }
}

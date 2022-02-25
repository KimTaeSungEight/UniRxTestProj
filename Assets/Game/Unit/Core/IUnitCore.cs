using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

namespace KimbaUnit.Core
{
    public interface IUnitCore
    {
        ISubject<UniRx.Unit> UnitDeadSubject { get; }   
        Moderator.IUnitModerator UnitProvider { get; }
    }
}

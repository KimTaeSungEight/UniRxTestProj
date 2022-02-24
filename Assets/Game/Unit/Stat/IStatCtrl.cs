using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Unit.Stat
{
    public interface IStatCtrl
    {
        UnitStat UnitStat { get; }

        void HandleHp(float changeHp);

        IReadOnlyReactiveProperty<float> Hp { get; }
    }
}

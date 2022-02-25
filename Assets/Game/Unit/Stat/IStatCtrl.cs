using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace KimbaUnit.Stat
{
    public interface IStatCtrl
    {
        UnitStat UnitStat { get; }

        void HandleHp(float changeHp);
        void Init(UnitStat unitStat);

        IReadOnlyReactiveProperty<float> Hp { get; }

    }
}

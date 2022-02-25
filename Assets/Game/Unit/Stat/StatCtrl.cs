using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace KimbaUnit.Stat
{
    public class StatCtrl : MonoBehaviour, IStatCtrl
    {
        private UnitStat _unitStat;
        public UnitStat UnitStat => _unitStat;

        private FloatReactiveProperty _hpProperty = new FloatReactiveProperty();

        public IReadOnlyReactiveProperty<float> Hp => _hpProperty;

        public void Init(UnitStat unitStat)
        {
            _unitStat = unitStat;
        }

        public void HandleHp(float changeHp)
        {
            _unitStat.hp.Value += changeHp;
        }
    }
}
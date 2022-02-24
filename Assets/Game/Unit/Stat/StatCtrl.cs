using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Unit.Stat
{
    public class StatCtrl
    {
        private UnitStat _unitStat;
        public UnitStat UnitStat => _unitStat;

        private FloatReactiveProperty _hpProperty;
        public FloatReactiveProperty HpProperty => _hpProperty;

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
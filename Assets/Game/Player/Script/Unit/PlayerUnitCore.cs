using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace KimbaUnit.Core
{
    public class PlayerUnitCore : UnitCoreBase
    {
        protected override void Init()
        {
            base.Init();

            Stat.UnitStat testUnitStat = new Stat.UnitStat();
            testUnitStat.moveSpeed = new FloatReactiveProperty(20.0f);
            testUnitStat.hp = new FloatReactiveProperty(100.0f);
            UnitProvider.Stat.Init(testUnitStat);
        }
    }
}
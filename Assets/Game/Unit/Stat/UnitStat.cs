using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace KimbaUnit.Stat
{
    public struct UnitStat
    {
        public int id;
        public string name;
        public FloatReactiveProperty hp;
        public FloatReactiveProperty moveSpeed;
        public float attackDamage;
        public float attackInterval;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using KimbaUnit.Stat;

namespace KimbaUnit.Movement 
{
    public class UnitMovement : MonoBehaviour ,IUnitMovement 
    {
        [SerializeField]
        protected Rigidbody2D _rigidbody2D;
        protected float _moveSpeed;

        public virtual void MovementInit(UnitStat unitStat) 
        {
            _moveSpeed = unitStat.moveSpeed.Value;
        }


        public virtual void Move(Vector2 dir){ }

        public virtual void Stop() { }
    }
}
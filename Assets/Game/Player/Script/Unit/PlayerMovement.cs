using System.Collections;
using System.Collections.Generic;
using KimbaUnit.Stat;
using UnityEngine;

namespace KimbaUnit.Movement
{
    public class PlayerMovement : UnitMovement
    {
        public override void Move(Vector2 dir)
        {
            _rigidbody2D.velocity = dir * _moveSpeed * Time.fixedDeltaTime;
        }

        public override void Stop()
        {
            _rigidbody2D.velocity = Vector2.zero;
        }
    }
}
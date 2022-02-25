using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KimbaUnit.Movement
{
    public interface IUnitMovement
    {
        void Move(Vector2 dir);

        void Stop();
    }
}

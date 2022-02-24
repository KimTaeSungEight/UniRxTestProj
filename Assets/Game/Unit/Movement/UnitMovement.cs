using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Unit {
    public class UnitMovement : MonoBehaviour ,IUnitMovement 
    {
        [SerializeField]
        private Rigidbody2D _rigidbody2D;
        private float _moveSpeed;

        public virtual void Move() {}

    }
}
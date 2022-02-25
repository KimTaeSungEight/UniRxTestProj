using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace FSM
{
    public class PMoveState : CustomFSMStateBase, KimbaInput.IInputEventDisposable
    {
        private System.IDisposable _inputDisposable;
        private System.IDisposable _moveDir;
        private KimbaUnit.Movement.IUnitMovement _unitMovement;
        private KimbaUnit.Ani.IAnimationCtrl _animtionCtrl;

        public System.IDisposable InputDisposable => _inputDisposable;

        public override void InitState(FSMSystem<TransitionCondition, IFSMStateBase> fsmSystem)
        {
            base.InitState(fsmSystem);

            _unitMovement = _unitProvider.Movement;
            _animtionCtrl = _unitProvider.Animation;
        }

        public override void StartState()
        {
            InuputSubscribe();
            _animtionCtrl.SetAniState(KimbaUnit.Ani.AnimationEnum.Move);
            Debug.Log("Move State Enter");
        }
        public override void UpdateState()
        {
        }
   
        public override void EndState()
        {
            _unitMovement.Stop();
            InputDispose();
        }

        public override bool Transition(TransitionCondition condition)
        {
            return true;
        }

        public void InuputSubscribe()
        {
            _inputDisposable = GameManager.Instance.InputEventProvider.InputEvent.Where(x => x == TransitionCondition.None)
            .Subscribe(x => FSMSystem.ChangeState(TransitionCondition.Idle));

            _moveDir = GameManager.Instance.InputEventProvider.MoveDirection.Subscribe(x => {
                _unitMovement.Move(x);
                });
        }

        public void InputDispose()
        {
            _inputDisposable.Dispose();
        }
    }
}
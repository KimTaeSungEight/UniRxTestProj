using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace FSM
{
    public class PIdleState : CustomFSMStateBase, KimbaInput.IInputEventDisposable
    {
        private KimbaUnit.Ani.IAnimationCtrl _animationCtrl;
        
        private System.IDisposable _inputDisposable;

        public System.IDisposable InputDisposable => _inputDisposable;

        public override void InitState(FSMSystem<TransitionCondition, IFSMStateBase> fsmSystem)
        {
            base.InitState(fsmSystem);

            _animationCtrl = _unitProvider.Animation;
        }

        public override void StartState()
        {
            Debug.Log("Idle State Enter");
            InuputSubscribe();
            _animationCtrl.SetAniState(KimbaUnit.Ani.AnimationEnum.Idle);
        }

        public override void UpdateState()
        {

        }

        public override void EndState()
        {
            Debug.Log("Idle State End");
            InputDispose();
        }

        public override bool Transition(TransitionCondition condition)
        {
            return true;
        }

        public void InuputSubscribe()
        {
            _inputDisposable = GameManager.Instance.InputEventProvider.InputEvent.Where(x => x == TransitionCondition.Move)
            .Subscribe(x => FSMSystem.ChangeState(x));
        }

        public void InputDispose()
        {
            _inputDisposable.Dispose();
        }
    }
}

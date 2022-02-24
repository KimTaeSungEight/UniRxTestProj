using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace FSM
{
    public class PMoveState : CustomFSMStateBase
    {
        System.IDisposable inputDisposable;

        public override void StartState()
        {
            Debug.Log("Move State Enter");


            inputDisposable = GameManager.Instance.InputEventProvider.InputEvent.Where(x => x == TransitionCondition.None)
                .Subscribe(x => FSMSystem.ChangeState(TransitionCondition.Idle));

        }
        public override void UpdateState()
        {
        }
   
        public override void EndState()
        {
            inputDisposable.Dispose();
        }

        public override bool Transition(TransitionCondition condition)
        {
            return true;
        }
    }
}
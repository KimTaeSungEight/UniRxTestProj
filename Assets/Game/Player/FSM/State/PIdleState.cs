using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace FSM
{
    public class PIdleState : CustomFSMStateBase
    {
        System.IDisposable inputDisposable;

        public override void StartState()
        {
            Debug.Log("Idle State Enter");

            inputDisposable = GameManager.Instance.InputEventProvider.InputEvent.Where(x => x == TransitionCondition.Move)
                .Subscribe(x => FSMSystem.ChangeState(x));
        }

        public override void UpdateState()
        {

        }

        public override void EndState()
        {
            Debug.Log("Idle State End");
            inputDisposable.Dispose();
        }

        public override bool Transition(TransitionCondition condition)
        {
            return true;
        }


    }
}

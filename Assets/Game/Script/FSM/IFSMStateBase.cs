using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    public enum TransitionCondition
    {
        None,
        Idle,
        Move,
        Attack,
    }

    public interface IFSMStateBase
    {
        void StartState();

        void UpdateState();

        void EndState();

        bool Transition(TransitionCondition condition);
    }

}

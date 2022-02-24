using FSM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace FSM
{
    public abstract class CustomFSMStateBase : MonoBehaviour, IFSMStateBase
    {
        private FSMSystem<System.Enum, IFSMStateBase> _fsmSystem = null;
        public FSMSystem<System.Enum, IFSMStateBase> FSMSystem => _fsmSystem;
        
        public virtual void InitState(FSMSystem<System.Enum, IFSMStateBase> fsmSystem)
        {
            this._fsmSystem = fsmSystem;
        }

        public abstract void StartState();
        public abstract void UpdateState();
        public abstract void EndState();

        public abstract bool Transition(TransitionCondition condition);

        [SerializeField]
        private TransitionCondition condition = TransitionCondition.None;

        public TransitionCondition Condition => condition;
    }
}
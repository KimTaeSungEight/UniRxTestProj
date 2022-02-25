using FSM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace FSM
{
    public abstract class CustomFSMStateBase : MonoBehaviour, IFSMStateBase
    {
        private FSMSystem<TransitionCondition, IFSMStateBase> _fsmSystem = null;
        public FSMSystem<TransitionCondition, IFSMStateBase> FSMSystem => _fsmSystem;
        
        public virtual void InitState(FSMSystem<TransitionCondition, IFSMStateBase> fsmSystem)
        {
            this._fsmSystem = fsmSystem;
            _unitProvider = GetComponentInParent<KimbaUnit.Moderator.IUnitModerator>();
        }

        public abstract void StartState();
        public abstract void UpdateState();
        public abstract void EndState();

        public abstract bool Transition(TransitionCondition condition);

        [SerializeField]
        private TransitionCondition condition = TransitionCondition.None;

        public TransitionCondition Condition => condition;

        protected KimbaUnit.Moderator.IUnitModerator _unitProvider;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM.Enemies
{

    public class EnemyFSMSystem : FSMSystem<TransitionCondition, CustomFSMStateBase>
    {
        [SerializeField]
        private List<CustomFSMStateBase> states;

        protected override void RegisterState()
        {
            for (int i = 0; i < states.Count; i++)
            {
                if (states[i].Condition == TransitionCondition.None)
                {
                    Debug.LogError("TransitionCondition is None");
                    return;
                }

                AddState(states[i].Condition, states[i]);
            }
        }
    }
}

using FSM;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestState : FSM.CustomFSMStateBase
{
    public override void EndState()
    {
        Debug.Log("HI");
    }

    public override void StartState()
    {
        Debug.Log("HI Start");
    }

    public override void UpdateState()
    {
        Debug.Log("Update State Hi");
    }
    public override bool Transition(TransitionCondition condition)
    {
        return false;
    }
}

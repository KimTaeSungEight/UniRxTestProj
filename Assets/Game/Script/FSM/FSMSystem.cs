using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public abstract class FSMSystem<EnumType, State> : MonoBehaviour where EnumType : System.Enum where State : FSM.IFSMStateBase
{
    [SerializeField] private EnumType _currState;
    public EnumType CurrState => _currState;

    [SerializeField] private EnumType _startState;
    public EnumType StartState => _startState;

    [SerializeField] private bool _isInit = false;
    public bool IsInit => _isInit;

    private Dictionary<EnumType, State> _fsmData = new Dictionary<EnumType, State>();


    private void Awake()
    {
        InitState();
    }

    private void InitState()
    {
        RegisterState();
        ChangeState(StartState);
        _isInit = true;

        this.UpdateAsObservable()
            .Where(_ => _isInit == true && _fsmData.ContainsKey(_currState) == true)
            .Subscribe(_ => _fsmData[CurrState].UpdateState());
    }

    protected abstract void RegisterState();

    public void ChangeState(EnumType state)
    {
        if (_fsmData.ContainsKey(state) == false)
            return;

        if (IsInit == true)
        {
            if(_fsmData.ContainsKey(_currState) == true)
            {
                _fsmData[CurrState].EndState();
            }
        }

        _currState = state;
        _fsmData[state].StartState();
    }
    
    protected bool GetContainsKey(EnumType type)
    {
        return _fsmData.ContainsKey(type);
    }

    protected State GetState(EnumType type)
    {
        if (_fsmData.ContainsKey(type) == false)
            return default(State);

        return _fsmData[type];
    }
}

using UniRx;
using UnityEngine;

namespace KimbaInput
{
    public interface IInputEventProvider
    {
        IReadOnlyReactiveProperty<Vector2> MoveDirection { get; }
        IReadOnlyReactiveProperty<FSM.TransitionCondition> InputEvent { get; }
    }
}
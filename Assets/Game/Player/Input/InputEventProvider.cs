using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace KimbaInput
{
    public class InputEventProvider : MonoBehaviour, IInputEventProvider
    {
        private readonly ReactiveProperty<Vector2> _moveDirection = new ReactiveProperty<Vector2>();
        private readonly ReactiveProperty<FSM.TransitionCondition> _inputEvent = new ReactiveProperty<FSM.TransitionCondition>();


        public IReadOnlyReactiveProperty<Vector2> MoveDirection => _moveDirection;

        public IReadOnlyReactiveProperty<FSM.TransitionCondition> InputEvent => _inputEvent;

        // Start is called before the first frame update
        void Start()
        {
            var token = this.GetCancellationTokenOnDestroy();
            InputDetectionLogic(token).Forget();

            _moveDirection.AddTo(this);
            _inputEvent.AddTo(this);
        }

        private async UniTaskVoid InputDetectionLogic(CancellationToken ct)
        {
            while (!ct.IsCancellationRequested)
            {
                if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
                {
                    _moveDirection.SetValueAndForceNotify(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
                    _inputEvent.Value = FSM.TransitionCondition.Move;
                    Debug.Log("MoveKeyDown");
                }

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    _inputEvent.Value = FSM.TransitionCondition.Attack;
                }


                if (Input.anyKey == false)
                {
                    _inputEvent.Value = FSM.TransitionCondition.None;
                    Debug.Log("AniKeyDown Is False");
                }

                Debug.Log(_inputEvent.Value.ToString());

                await UniTask.Yield();

            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace KimbaInput
{
    public interface IInputEventDisposable
    {
        IDisposable InputDisposable { get; }
        void InuputSubscribe();
        void InputDispose();
    }
}
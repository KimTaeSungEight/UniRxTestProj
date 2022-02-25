using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KimbaUnit.Moderator
{
    public interface IUnitModerator
    {
        Movement.IUnitMovement Movement { get; }
        Ani.IAnimationCtrl Animation { get; }
        Core.IUnitCore Unit { get; }

        Stat.IStatCtrl Stat { get; }
    }
}
using GBFRDataTools.FSM.Components.Actions.AI.Enemy;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300DamageMotionPlayDirAction : EmDamageMotionPlayDirAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300DamageMotionPlayDirAction);

    [JsonPropertyName("animIdPowerList_")]
    public BindingList<string> AnimIdPowerList { get; set; } = ["b510", "b511", "b512", "b513"];

    public Em7300DamageMotionPlayDirAction()
    {
        EnabledFrontDegree = 45f;
        EnabledBackDegree = 45f;
        IsChangeAnimMovementRate = false;
        AnimMovementRate = Vector4.One;
        IsCalcDirbyAttackerPos = false;
        AnimBlendEaseFrame = 0;
        AnimBlendRate = 0f;
        AnimStartFrame = 0;
        AnimStartStep = 0;
        AnimSpeedRate = 0f;
        AnimSpeedStep = 0;
    }
}

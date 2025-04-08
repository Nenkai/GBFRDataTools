using GBFRDataTools.FSM.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmDamageMotionPlayMiddleAction : EmDamageMotionPlayDirAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmDamageMotionPlayMiddleAction);

    [JsonPropertyName("frontAnimIdList_")]
    public BindingList<string> FrontAnimIdList { get; set; } = ["0506", "0507"];

    public EmDamageMotionPlayMiddleAction()
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

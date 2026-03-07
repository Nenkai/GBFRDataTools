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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wolf;

public class Em0200DamageMotionPlayDirAction : EmDamageMotionPlayDirAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200DamageMotionPlayDirAction);

    [JsonPropertyName("riderAnimIdList_")]
    public BindingList<int> RiderAnimIdList { get; set; } = [0, 1, 2, 3];

    public Em0200DamageMotionPlayDirAction()
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

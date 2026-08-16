using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonAttackSignAdjustGroundAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonAttackSignAdjustGroundAction);

    [JsonPropertyName("checkLength_")]
    public float CheckLength { get; set; } = 2f;

    [JsonPropertyName("wallAngle_")]
    public float WallAngle { get; set; } = 45f;

    [JsonPropertyName("moveYSpeed_")]
    public float MoveYSpeed { get; set; } = 0.2f;

    [JsonPropertyName("checkSubRadius_")]
    public float CheckSubRadius { get; set; } = 0.1f;

    [JsonPropertyName("isDrawDebug_")]
    [Obsolete("Not exposed by the executable")]
    public bool IsDrawDebug { get; set; } = false;
}

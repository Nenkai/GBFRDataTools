using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

[GameSupport(GameVersion.EndlessRagnarok)]
public class BehaviorAddScaleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BehaviorAddScaleAction);

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();

    [JsonPropertyName("addScale_")]
    public float AddScale { get; set; } = 0f;

    [JsonPropertyName("isLimitScale_")]
    public bool IsLimitScale { get; set; } = false;

    [JsonPropertyName("maxLimitScale_")]
    public float MaxLimitScale { get; set; } = 1f;

    [JsonPropertyName("minLimitScale_")]
    public float MinLimitScale { get; set; } = 0f;

    [JsonPropertyName("waitSecMax_")]
    public float WaitSecMax { get; set; } = 0f;

    [JsonPropertyName("changeSecMax_")]
    public float ChangeSecMax { get; set; } = 0f;

    [JsonPropertyName("isChangeX_")]
    public bool IsChangeX { get; set; } = true;

    [JsonPropertyName("isChangeY_")]
    public bool IsChangeY { get; set; } = true;

    [JsonPropertyName("isChangeZ_")]
    public bool IsChangeZ { get; set; } = true;
}
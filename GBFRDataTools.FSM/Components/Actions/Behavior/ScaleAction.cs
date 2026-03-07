using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class ScaleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ScaleAction);

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();

    [JsonPropertyName("scaleStart_")]
    public float ScaleStart { get; set; } = 1.0f;

    [JsonPropertyName("scaleEnd_")]
    public float ScaleEnd { get; set; } = 1.0f;

    [JsonPropertyName("waitSecMax_")]
    public float WaitSecMax { get; set; } = 0.0f;

    [JsonPropertyName("changeSecMax_")]
    public float ChangeSecMax { get; set; } = 0.0f;

    [JsonPropertyName("isChangeX_")]
    public bool IsChangeX { get; set; } = true;

    [JsonPropertyName("isChangeY_")]
    public bool IsChangeY { get; set; } = true;

    [JsonPropertyName("isChangeZ_")]
    public bool IsChangeZ { get; set; } = true;

    [JsonPropertyName("isMulScale_")]
    public bool IsMulScale { get; set; } = false;
}
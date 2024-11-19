using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class ScaleAction : ActionComponent
{
    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; }

    [JsonPropertyName("scaleStart_")]
    public float ScaleStart { get; set; }

    [JsonPropertyName("scaleEnd_")]
    public float ScaleEnd { get; set; }

    [JsonPropertyName("waitSecMax_")]
    public float WaitSecMax { get; set; }

    [JsonPropertyName("changeSecMax_")]
    public float ChangeSecMax { get; set; }

    [JsonPropertyName("isChangeX_")]
    public bool IsChangeX { get; set; }

    [JsonPropertyName("isChangeY_")]
    public bool IsChangeY { get; set; }

    [JsonPropertyName("isChangeZ_")]
    public bool IsChangeZ { get; set; }

    [JsonPropertyName("isMulScale_")]
    public bool IsMulScale { get; set; }
}
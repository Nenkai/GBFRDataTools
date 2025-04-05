using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class AlphaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AlphaAction);

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();

    [JsonPropertyName("alphaStart_")]
    public float AlphaStart { get; set; } = 1.0f;

    [JsonPropertyName("alphaEnd_")]
    public float AlphaEnd { get; set; } = 1.0f;

    [JsonPropertyName("changeSecMax_")]
    public float ChangeSecMax { get; set; } = 0.0f;

    [JsonPropertyName("applyToChildRecursively_")]
    public bool ApplyToChildRecursively { get; set; } = false;
}
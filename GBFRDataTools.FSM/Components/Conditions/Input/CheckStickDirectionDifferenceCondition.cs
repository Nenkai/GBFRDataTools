using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Input;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CheckStickDirectionDifferenceCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckStickDirectionDifferenceCondition);

    [JsonPropertyName("checkAngle_")]
    public float CheckAngle { get; set; } = 120f;

    [JsonPropertyName("isCheckLR_")]
    public bool IsCheckLR { get; set; } = false;

    [JsonPropertyName("isCheckL_")]
    public bool IsCheckL { get; set; } = false;

    [JsonPropertyName("isUseOffsetAngle_")]
    public bool IsUseOffsetAngle { get; set; } = false;

    [JsonPropertyName("chrOffsetAngle_")]
    public float ChrOffsetAngle { get; set; } = 0f;
}
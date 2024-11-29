using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;
namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmDamageMotionPlayDirAction : ActionComponent
{
    [JsonPropertyName("enabledFrontDegree_")]
    public float EnabledFrontDegree { get; set; } = 45.0f;

    [JsonPropertyName("enabledBackDegree_")]
    public float EnabledBackDegree { get; set; } = 45.0f;

    [JsonPropertyName("animIdList_")]
    public BindingList<string> AnimIdList { get; set; } = ["0500", "0501", "0502", "0503"];

    [JsonPropertyName("isChangeAnimMovementRate_")]
    public bool IsChangeAnimMovementRate { get; set; } = false;

    [JsonPropertyName("animMovementRate_")]
    public /* cVec4 */ Vector4 AnimMovementRate { get; set; } = Vector4.One;

    [JsonPropertyName("isCalcDirbyAttackerPos_")]
    public bool IsCalcDirbyAttackerPos { get; set; } = false;

    [JsonPropertyName("animBlendEaseFrame_")]
    public int AnimBlendEaseFrame { get; set; } = 0;

    [JsonPropertyName("animBlendRate_")]
    public float AnimBlendRate { get; set; } = 0.0f;

    [JsonPropertyName("animStartFrame_")]
    public int AnimStartFrame { get; set; } = 0;

    [JsonPropertyName("animStartStep_")]
    public int AnimStartStep { get; set; } = 0;

    [JsonPropertyName("animSpeedRate_")]
    public float AnimSpeedRate { get; set; } = 0.0f;

    [JsonPropertyName("animSpeedStep_")]
    public int AnimSpeedStep { get; set; } = 0;
}

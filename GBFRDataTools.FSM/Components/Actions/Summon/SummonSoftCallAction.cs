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
public class SummonSoftCallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSoftCallAction);

    [JsonPropertyName("actionType_")]
    public int ActionType { get; set; } = 0;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;

    [JsonPropertyName("softCallType_")]
    public int SoftCallType { get; set; } = 0;

    [JsonPropertyName("beginPos_")]
    public Vector4 BeginPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("endPos_")]
    public Vector4 EndPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isLocalBeginPos_")]
    public bool IsLocalBeginPos { get; set; } = true;

    [JsonPropertyName("isLocalEndPos_")]
    public bool IsLocalEndPos { get; set; } = true; 

    [JsonPropertyName("beginPosBBKey_")]
    public string BeginPosBBKey { get; set; }

    [JsonPropertyName("endPosBBKey_")]
    public string EndPosBBKey { get; set; }

    [JsonPropertyName("defineName_")]
    public string DefineName { get; set; }

    [JsonPropertyName("isImmediate_")]
    public bool IsImmediate { get; set; } = false;

    [JsonPropertyName("isForce_")]
    public bool IsForce { get; set; } = false;

    [JsonPropertyName("isAutoRelease_")]
    public bool IsAutoRelease { get; set; } = false;

    [JsonPropertyName("isScaleCircle_")]
    public bool IsScaleCircle { get; set; } = false;

    [JsonPropertyName("scalingSec_")]
    public float ScalingSec { get; set; } = 0f;

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("innerRadius_")]
    public float InnerRadius { get; set; } = 0f;

    [JsonPropertyName("outerRadius_")]
    public float OuterRadius { get; set; } = 0f;

    [JsonPropertyName("scaledInnerRadius_")]
    public float ScaledInnerRadius { get; set; } = 0f;

    [JsonPropertyName("scaledOuterRadius_")]
    public float ScaledOuterRadius { get; set; } = 0f;

    [JsonPropertyName("fadingSec_")]
    public float FadingSec { get; set; } = 0f;
}

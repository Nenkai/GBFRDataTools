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
public class SummonSetUnitParameterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSetUnitParameterAction);

    [JsonPropertyName("saveValueVector_")]
    public Vector4 SaveValueVector { get; set; } = Vector4.UnitW;

    [JsonPropertyName("saveValueInt_")]
    public int SaveValueInt { get; set; } = 0;

    [JsonPropertyName("saveValueFloat_")]
    public float SaveValueFloat { get; set; } = 0f;

    [JsonPropertyName("setType_")]
    public int SetType { get; set; } = 0;

    [JsonPropertyName("dataIndex_")]
    public int DataIndex { get; set; } = 0;

    [JsonPropertyName("targetBBName_")]
    public string TargetBBName { get; set; }

    [JsonPropertyName("isUseBlackBoardInput_")]
    public bool IsUseBlackBoardInput { get; set; } = false;

    [JsonPropertyName("isUpdateInput_")]
    public bool IsUpdateInput { get; set; } = false;

    [JsonPropertyName("isUseOwnerPos_")]
    public bool IsUseOwnerPos { get; set; } = false;

    [JsonPropertyName("isUseOwnerFrontVec_")]
    public bool IsUseOwnerFrontVec { get; set; } = false;

    [JsonPropertyName("isShotCall_")]
    public bool IsShotCall { get; set; } = false;

    [JsonPropertyName("isAutoIndexInput_")]
    public bool IsAutoIndexInput { get; set; } = false;

    [JsonPropertyName("isManualPlayerSummoningSetting_")]
    public bool IsManualPlayerSummoningSetting { get; set; } = false;
}

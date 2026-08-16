using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Conditions.AI;

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
public class SummonStickMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonStickMoveAction);

    [JsonPropertyName("initialMoveRate_")]
    public float InitialMoveRate { get; set; } = 0f;

    [JsonPropertyName("moveRate_")]
    public float MoveRate { get; set; } = 0.1f;

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 60f;

    [JsonPropertyName("inputNeedTimeMin_")]
    public float InputNeedTimeMin { get; set; } = 0f;

    [JsonPropertyName("inputNeedTimeMax_")]
    public float InputNeedTimeMax { get; set; } = 1f;

    [JsonPropertyName("isMoveFrontOnly_")]
    public bool IsMoveFrontOnly { get; set; } = true;

    [JsonPropertyName("isDecel_")]
    public bool IsDecel { get; set; } = false;

    [JsonPropertyName("decelSpeed_")]
    public float DecelSpeed { get; set; } = 60f;

    [JsonPropertyName("isControlByBb_")]
    public bool IsControlByBb { get; set; } = false;

    [JsonPropertyName("isControlBbKey_")]
    public string IsControlBbKey { get; set; }

    [JsonPropertyName("isAdjustNearWall_")]
    public bool IsAdjustNearWall { get; set; } = false;

    [JsonPropertyName("wallCheckLineHeight_")]
    public float WallCheckLineHeight { get; set; } = 0f;

    [JsonPropertyName("wallCheckLineDist_")]
    public float WallCheckLineDist { get; set; } = 0f;

    [JsonPropertyName("wallCheckAdjustRate_")]
    public float WallCheckAdjustRate { get; set; } = 0f;

    [JsonPropertyName("isSetSummonGroupMoveVec_")]
    public bool IsSetSummonGroupMoveVec { get; set; } = false;

    [JsonPropertyName("setSummonGroupMoveVecIndex_")]
    public int SetSummonGroupMoveVecIndex { get; set; } = 0;
}

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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Albacore;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So4e00BlitzAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So4e00BlitzAction);

    [JsonPropertyName("wallCheckHeight_")]
    public float WallCheckHeight { get; set; } = 2f;

    [JsonPropertyName("groundCheckHeight_")]
    public float GroundCheckHeight { get; set; } = 5f;

    [JsonPropertyName("inputTimeFrame_")]
    public int InputTimeFrame { get; set; } = 0;

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.03f;

    [JsonPropertyName("lockOnTurnRate_")]
    public float LockOnTurnRate { get; set; } = 0.1f;

    [JsonPropertyName("attackSignTimeFrame_")]
    public int AttackSignTimeFrame { get; set; } = 0;

    [JsonPropertyName("attackSignSize_")]
    public Vector4 AttackSignSize { get; set; } = Vector4.UnitW;

    [JsonPropertyName("attackSignPosOffset_")]
    public Vector4 AttackSignPosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0f;

    [JsonPropertyName("stopSpeed_")]
    public float StopSpeed { get; set; } = 0f;

    [JsonPropertyName("moveTimeUpSec_")]
    public float MoveTimeUpSec { get; set; } = 3f;

    [JsonPropertyName("moveDistMax_")]
    public float MoveDistMax { get; set; } = 0f;

    [JsonPropertyName("hideTime_")]
    public float HideTime { get; set; } = 0f;

    [JsonPropertyName("returnSignCheckDist_")]
    public float ReturnSignCheckDist { get; set; } = 15f;

    [JsonPropertyName("returnSignTime_")]
    public float ReturnSignTime { get; set; } = 1f;

    [JsonPropertyName("returnSignOffset_")]
    public Vector4 ReturnSignOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("returnMoveCheckDist_")]
    public float ReturnMoveCheckDist { get; set; } = 0f;

    [JsonPropertyName("stopDistance_")]
    public float StopDistance { get; set; } = 0f;

    [JsonPropertyName("odEnemyHitDamageRate_")]
    public float OdEnemyHitDamageRate { get; set; } = 1.5f;
}

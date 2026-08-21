using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;

public class Em2600DigPopAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2600DigPopAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.5f; 

    [JsonPropertyName("chaseHomingAngle_")]
    public float ChaseHomingAngle { get; set; } = 0.05f; 

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0.3f; 

    [JsonPropertyName("nearLength_")]
    public float NearLength { get; set; } = 0.1f; 

    [JsonPropertyName("chaseSec_")]
    public float ChaseSec { get; set; } = 7f; 

    [JsonPropertyName("wallHitChaseSecRate_")]
    public float WallHitChaseSecRate { get; set; } = 3.5f; 

    [JsonPropertyName("isStartDiged_")]
    public bool IsStartDiged { get; set; } = false; 

    [JsonPropertyName("isChase_")]
    public bool IsChase { get; set; } = true; 

    [JsonPropertyName("isLookFoundTarget_")]
    public bool IsLookFoundTarget { get; set; } = false; 

    [JsonPropertyName("wallDegX_")]
    public float WallDegX { get; set; } = 40f; 

    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; } = 2f; 

    [JsonPropertyName("isPoisonAttribute_")]
    public bool IsPoisonAttribute { get; set; } = false; 

    [JsonPropertyName("isShotPoisonGas_")]
    public bool IsShotPoisonGas { get; set; } = false; 

    [JsonPropertyName("shotGasNum_")]
    public int ShotGasNum { get; set; } = 4; 

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("digEffectId_")]
    public int DigEffectId { get; set; } = 105; 

    [JsonPropertyName("digPoisonEffectId_")]
    public int DigPoisonEffectId { get; set; } = 107; 

    [JsonPropertyName("startOffMeshLinkMoveDelay_")]
    public float StartOffMeshLinkMoveDelay { get; set; } = 1f; 

    [JsonPropertyName("endOffMeshLinkMoveDelay_")]
    public float EndOffMeshLinkMoveDelay { get; set; } = 0.6f; 

    [JsonPropertyName("offMeshLinkMoveShowVfxDelay_")]
    public float OffMeshLinkMoveShowVfxDelay { get; set; } = 0.25f; 
}

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
    public float HomingAngle { get; set; } = 0.5f; // Offset 0x84

    [JsonPropertyName("chaseHomingAngle_")]
    public float ChaseHomingAngle { get; set; } = 0.05f; // Offset 0x8C

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0.3f; // Offset 0x90

    [JsonPropertyName("nearLength_")]
    public float NearLength { get; set; } = 0.1f; // Offset 0x9C

    [JsonPropertyName("chaseSec_")]
    public float ChaseSec { get; set; } = 7f; // Offset 0x94

    [JsonPropertyName("wallHitChaseSecRate_")]
    public float WallHitChaseSecRate { get; set; } = 3.5f; // Offset 0x98

    [JsonPropertyName("isStartDiged_")]
    public bool IsStartDiged { get; set; } = false; // Offset 0x88

    [JsonPropertyName("isChase_")]
    public bool IsChase { get; set; } = true; // Offset 0x89

    [JsonPropertyName("isLookFoundTarget_")]
    public bool IsLookFoundTarget { get; set; } = false; // Offset 0x8A

    [JsonPropertyName("wallDegX_")]
    public float WallDegX { get; set; } = 40f; // Offset 0xA0

    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; } = 2f; // Offset 0xB0

    [JsonPropertyName("isPoisonAttribute_")]
    public bool IsPoisonAttribute { get; set; } = false; // Offset 0xB4

    [JsonPropertyName("isShotPoisonGas_")]
    public bool IsShotPoisonGas { get; set; } = false; // Offset 0xB5

    [JsonPropertyName("shotGasNum_")]
    public int ShotGasNum { get; set; } = 4; // Offset 0xB8

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0xC0

    [JsonPropertyName("digEffectId_")]
    public int DigEffectId { get; set; } = 105; // Offset 0xD0

    [JsonPropertyName("digPoisonEffectId_")]
    public int DigPoisonEffectId { get; set; } = 107; // Offset 0xD4

    [JsonPropertyName("startOffMeshLinkMoveDelay_")]
    public float StartOffMeshLinkMoveDelay { get; set; } = 1f; // Offset 0xA4

    [JsonPropertyName("endOffMeshLinkMoveDelay_")]
    public float EndOffMeshLinkMoveDelay { get; set; } = 0.6f; // Offset 0xA8

    [JsonPropertyName("offMeshLinkMoveShowVfxDelay_")]
    public float OffMeshLinkMoveShowVfxDelay { get; set; } = 0.25f; // Offset 0xAC

    public Em2600DigPopAction()
    {
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1000DiveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1000DiveAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.3f; // Offset 0xB8

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.5235988f; // Offset 0xBC

    [JsonPropertyName("attackPosRandomMaxDist_")]
    public float AttackPosRandomMaxDist { get; set; } = 2f; // Offset 0xC0

    [JsonPropertyName("attackStartDelay_")]
    public float AttackStartDelay { get; set; } = 0.03f; // Offset 0xC4

    [JsonPropertyName("preAttackTime_")]
    public float PreAttackTime { get; set; } = 1.5f; // Offset 0xC8

    [JsonPropertyName("gravity_")]
    public float Gravity { get; set; } = 0.03f; // Offset 0xCC

    [JsonPropertyName("jumpPower_")]
    public float JumpPower { get; set; } = 0.1f; // Offset 0xD0

    [JsonPropertyName("fallMotionPlayRestTime_")]
    public float FallMotionPlayRestTime { get; set; } = 0.7f; // Offset 0xE0

    [JsonPropertyName("addJumpPowerOnHeight_")]
    public float AddJumpPowerOnHeight { get; set; } = 0.001f; // Offset 0xD4

    [JsonPropertyName("attackMarkerFrontPos_")]
    public float AttackMarkerFrontPos { get; set; } = 0f; // Offset 0xD8

    [JsonPropertyName("attackMarkerRadius_")]
    public float AttackMarkerRadius { get; set; } = 2.5f; // Offset 0xDC

    [JsonPropertyName("wallHitTime_")]
    public float WallHitTime { get; set; } = 0.7f; // Offset 0xE4

    [JsonPropertyName("jumpTime_")]
    public float JumpTime { get; set; } = 50f; // Offset 0xE8

    [JsonPropertyName("fallTime_")]
    public float FallTime { get; set; } = 30f; // Offset 0xEC

    [JsonPropertyName("nearDistance_")]
    public float NearDistance { get; set; } = 8f; // Offset 0xF0

    [JsonPropertyName("minimumAttackDistance_")]
    public float MinimumAttackDistance { get; set; } = 8f; // Offset 0xF4

    [JsonPropertyName("fallStartDistanceRate_")]
    public float FallStartDistanceRate { get; set; } = 0.6f; // Offset 0xF8

    [JsonPropertyName("flyGravityRate_")]
    public float FlyGravityRate { get; set; } = 0.2f; // Offset 0xFC

    [JsonPropertyName("flyGravityTime_")]
    public float FlyGravityTime { get; set; } = 17f; // Offset 0x100

    [JsonPropertyName("attackSignSec_")]
    public float AttackSignSec { get; set; } = 2.6f; // Offset 0x104

    public Em1000DiveAction()
    {
    }
}
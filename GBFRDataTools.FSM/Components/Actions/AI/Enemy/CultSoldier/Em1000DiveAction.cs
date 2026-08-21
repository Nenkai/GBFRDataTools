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
    public float TurnRate { get; set; } = 0.3f; 

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.5235988f; 

    [JsonPropertyName("attackPosRandomMaxDist_")]
    public float AttackPosRandomMaxDist { get; set; } = 2f; 

    [JsonPropertyName("attackStartDelay_")]
    public float AttackStartDelay { get; set; } = 0.03f; 

    [JsonPropertyName("preAttackTime_")]
    public float PreAttackTime { get; set; } = 1.5f; 

    [JsonPropertyName("gravity_")]
    public float Gravity { get; set; } = 0.03f; 

    [JsonPropertyName("jumpPower_")]
    public float JumpPower { get; set; } = 0.1f; 

    [JsonPropertyName("fallMotionPlayRestTime_")]
    public float FallMotionPlayRestTime { get; set; } = 0.7f; 

    [JsonPropertyName("addJumpPowerOnHeight_")]
    public float AddJumpPowerOnHeight { get; set; } = 0.001f; 

    [JsonPropertyName("attackMarkerFrontPos_")]
    public float AttackMarkerFrontPos { get; set; } = 0f; 

    [JsonPropertyName("attackMarkerRadius_")]
    public float AttackMarkerRadius { get; set; } = 2.5f; 

    [JsonPropertyName("wallHitTime_")]
    public float WallHitTime { get; set; } = 0.7f; 

    [JsonPropertyName("jumpTime_")]
    public float JumpTime { get; set; } = 50f; 

    [JsonPropertyName("fallTime_")]
    public float FallTime { get; set; } = 30f; 

    [JsonPropertyName("nearDistance_")]
    public float NearDistance { get; set; } = 8f; 

    [JsonPropertyName("minimumAttackDistance_")]
    public float MinimumAttackDistance { get; set; } = 8f; 

    [JsonPropertyName("fallStartDistanceRate_")]
    public float FallStartDistanceRate { get; set; } = 0.6f; 

    [JsonPropertyName("flyGravityRate_")]
    public float FlyGravityRate { get; set; } = 0.2f; 

    [JsonPropertyName("flyGravityTime_")]
    public float FlyGravityTime { get; set; } = 17f; 

    [JsonPropertyName("attackSignSec_")]
    public float AttackSignSec { get; set; } = 2.6f; 
}
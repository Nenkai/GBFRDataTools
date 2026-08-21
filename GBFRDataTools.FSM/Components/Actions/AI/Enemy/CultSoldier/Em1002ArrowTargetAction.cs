using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1002ArrowTargetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1002ArrowTargetAction);

    [JsonPropertyName("targetSuccessAngleDeg_")]
    public float TargetSuccessAngleDeg { get; set; } = 40f; 

    [JsonPropertyName("targetTotalTime_")]
    public float TargetTotalTime { get; set; } = 3f; 

    [JsonPropertyName("targetMinTime_")]
    public float TargetMinTime { get; set; } = 1f; 

    [JsonPropertyName("targetSuccessTime_")]
    public float TargetSuccessTime { get; set; } = 1f; 

    [JsonPropertyName("targetFailedTime_")]
    public float TargetFailedTime { get; set; } = 1f; 

    [JsonPropertyName("turnStartAngleDeg_")]
    public float TurnStartAngleDeg { get; set; } = 5f; 

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.1f; 

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.1f; 

    [JsonPropertyName("verticalChangeDegSpeed_")]
    public float VerticalChangeDegSpeed { get; set; } = 20f; 

    [JsonPropertyName("topTargetVerticalDeg_")]
    public float TopTargetVerticalDeg { get; set; } = 80f; 

    [JsonPropertyName("middleTargetVerticalDeg_")]
    public float MiddleTargetVerticalDeg { get; set; } = 45f; 

    [JsonPropertyName("lowTargetVerticalDeg_")]
    public float LowTargetVerticalDeg { get; set; } = 0f; 

    [JsonPropertyName("targetVerticalJointNo_")]
    public int TargetVerticalJointNo { get; set; } = 0; 

    [JsonPropertyName("setupTurnMaxAngle_")]
    public float SetupTurnMaxAngle { get; set; } = 0.1f; 

    [JsonPropertyName("preShotTime_")]
    public float PreShotTime { get; set; } = 0.5f; 

    [JsonPropertyName("motionInterTime_")]
    public float MotionInterTime { get; set; } = 0.2f; 

    [JsonPropertyName("walkStartDistance_")]
    public float WalkStartDistance { get; set; } = 5f; 

    [JsonPropertyName("maxBlendDeg_")]
    public float MaxBlendDeg { get; set; } = 40f; 

    [JsonPropertyName("moveForecastMul_")]
    public float MoveForecastMul { get; set; } = 0.7f; 

    [JsonPropertyName("moveForecastShotSpeed_")]
    public float MoveForecastShotSpeed { get; set; } = 30f; 

    [JsonPropertyName("forecastSpeedUpdateTime_")]
    public float ForecastSpeedUpdateTime { get; set; } = 0.5f; 

    [JsonPropertyName("curForeCastDirTime_")]
    public float CurForeCastDirTime { get; set; } = 0.5f; 
}
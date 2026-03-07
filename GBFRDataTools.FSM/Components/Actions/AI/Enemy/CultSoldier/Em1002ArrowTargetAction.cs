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
    public float TargetSuccessAngleDeg { get; set; } = 40f; // Offset 0x7C

    [JsonPropertyName("targetTotalTime_")]
    public float TargetTotalTime { get; set; } = 3f; // Offset 0x68

    [JsonPropertyName("targetMinTime_")]
    public float TargetMinTime { get; set; } = 1f; // Offset 0x78

    [JsonPropertyName("targetSuccessTime_")]
    public float TargetSuccessTime { get; set; } = 1f; // Offset 0x6C

    [JsonPropertyName("targetFailedTime_")]
    public float TargetFailedTime { get; set; } = 1f; // Offset 0x70

    [JsonPropertyName("turnStartAngleDeg_")]
    public float TurnStartAngleDeg { get; set; } = 5f; // Offset 0x80

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.1f; // Offset 0x84

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.1f; // Offset 0x88

    [JsonPropertyName("verticalChangeDegSpeed_")]
    public float VerticalChangeDegSpeed { get; set; } = 20f; // Offset 0x90

    [JsonPropertyName("topTargetVerticalDeg_")]
    public float TopTargetVerticalDeg { get; set; } = 80f; // Offset 0x94

    [JsonPropertyName("middleTargetVerticalDeg_")]
    public float MiddleTargetVerticalDeg { get; set; } = 45f; // Offset 0x98

    [JsonPropertyName("lowTargetVerticalDeg_")]
    public float LowTargetVerticalDeg { get; set; } = 0f; // Offset 0x9C

    [JsonPropertyName("targetVerticalJointNo_")]
    public int TargetVerticalJointNo { get; set; } = 0; // Offset 0xA0

    [JsonPropertyName("setupTurnMaxAngle_")]
    public float SetupTurnMaxAngle { get; set; } = 0.1f; // Offset 0x8C

    [JsonPropertyName("preShotTime_")]
    public float PreShotTime { get; set; } = 0.5f; // Offset 0x74

    [JsonPropertyName("motionInterTime_")]
    public float MotionInterTime { get; set; } = 0.2f; // Offset 0xA8

    [JsonPropertyName("walkStartDistance_")]
    public float WalkStartDistance { get; set; } = 5f; // Offset 0xA4

    [JsonPropertyName("maxBlendDeg_")]
    public float MaxBlendDeg { get; set; } = 40f; // Offset 0xAC

    [JsonPropertyName("moveForecastMul_")]
    public float MoveForecastMul { get; set; } = 0.7f; // Offset 0xB0

    [JsonPropertyName("moveForecastShotSpeed_")]
    public float MoveForecastShotSpeed { get; set; } = 30f; // Offset 0xB4

    [JsonPropertyName("forecastSpeedUpdateTime_")]
    public float ForecastSpeedUpdateTime { get; set; } = 0.5f; // Offset 0xB8

    [JsonPropertyName("curForeCastDirTime_")]
    public float CurForeCastDirTime { get; set; } = 0.5f; // Offset 0x10C

    public Em1002ArrowTargetAction()
    {
    }
}
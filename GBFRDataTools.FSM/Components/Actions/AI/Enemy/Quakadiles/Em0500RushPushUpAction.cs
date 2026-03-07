using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500RushPushUpAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500RushPushUpAction);

    [JsonPropertyName("startHomingAngle_")]
    public float StartHomingAngle { get; set; } = 3f; // Offset 0x10C

    [JsonPropertyName("loopHomingAngle_")]
    public float LoopHomingAngle { get; set; } = 0.5f; // Offset 0x110

    [JsonPropertyName("rushMinSeconds_")]
    public float RushMinSeconds { get; set; } = 0f; // Offset 0x114

    [JsonPropertyName("rushMaxSeconds_")]
    public float RushMaxSeconds { get; set; } = 5f; // Offset 0x118

    [JsonPropertyName("nextDistance_")]
    public float NextDistance { get; set; } = 5f; // Offset 0x11C

    [JsonPropertyName("nextAngle_")]
    public float NextAngle { get; set; } = 30f; // Offset 0x120

    [JsonPropertyName("endAngle_")]
    public float EndAngle { get; set; } = 90f; // Offset 0x124

    [JsonPropertyName("doublePushUp_")]
    public bool DoublePushUp { get; set; } = false; // Offset 0x128

    [JsonPropertyName("highVoltage_")]
    public bool HighVoltage { get; set; } = false; // Offset 0x129

    [JsonPropertyName("highVoltageLoopEndMotionRate_")]
    public float HighVoltageLoopEndMotionRate { get; set; } = 1.5f; // Offset 0x12C

    [JsonPropertyName("driftCount_")]
    public int DriftCount { get; set; } = 0; // Offset 0x130

    [JsonPropertyName("driftInterval_")]
    public float DriftInterval { get; set; } = 1.2f; // Offset 0x134

    [JsonPropertyName("driftCheckAngle_")]
    public float DriftCheckAngle { get; set; } = 30f; // Offset 0x138

    [JsonPropertyName("driftBodyHormingAngle_")]
    public float DriftBodyHormingAngle { get; set; } = 2f; // Offset 0x13C

    [JsonPropertyName("driftVectorHormingAngle_")]
    public float DriftVectorHormingAngle { get; set; } = 0.5f; // Offset 0x140

    [JsonPropertyName("driftSpeedMag_")]
    public float DriftSpeedMag { get; set; } = 0.98f; // Offset 0x144

    [JsonPropertyName("driftTransSpeed_")]
    public float DriftTransSpeed { get; set; } = 5f; // Offset 0x148

    [JsonPropertyName("isTailSlash_")]
    public bool IsTailSlash { get; set; } = false; // Offset 0x14C

    [JsonPropertyName("iceCrushOffset_")]
    public Vector4 IceCrushOffset { get; set; } = new Vector4(0f, 0f, 6f, 1f); // Offset 0x150

    [JsonPropertyName("isTutorialMotion_")]
    public bool IsTutorialMotion { get; set; } = false; // Offset 0x160

    [JsonPropertyName("tutotialMotionLoopTime_")]
    public float TutotialMotionLoopTime { get; set; } = 2f; // Offset 0x164

    public Em0500RushPushUpAction()
    {
    }
}



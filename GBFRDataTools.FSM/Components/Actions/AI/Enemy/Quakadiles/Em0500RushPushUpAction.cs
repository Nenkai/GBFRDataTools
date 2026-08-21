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
    public float StartHomingAngle { get; set; } = 3f; 

    [JsonPropertyName("loopHomingAngle_")]
    public float LoopHomingAngle { get; set; } = 0.5f; 

    [JsonPropertyName("rushMinSeconds_")]
    public float RushMinSeconds { get; set; } = 0f; 

    [JsonPropertyName("rushMaxSeconds_")]
    public float RushMaxSeconds { get; set; } = 5f; 

    [JsonPropertyName("nextDistance_")]
    public float NextDistance { get; set; } = 5f; 

    [JsonPropertyName("nextAngle_")]
    public float NextAngle { get; set; } = 30f; 

    [JsonPropertyName("endAngle_")]
    public float EndAngle { get; set; } = 90f; 

    [JsonPropertyName("doublePushUp_")]
    public bool DoublePushUp { get; set; } = false; 

    [JsonPropertyName("highVoltage_")]
    public bool HighVoltage { get; set; } = false; 

    [JsonPropertyName("highVoltageLoopEndMotionRate_")]
    public float HighVoltageLoopEndMotionRate { get; set; } = 1.5f; 

    [JsonPropertyName("driftCount_")]
    public int DriftCount { get; set; } = 0; 

    [JsonPropertyName("driftInterval_")]
    public float DriftInterval { get; set; } = 1.2f; 

    [JsonPropertyName("driftCheckAngle_")]
    public float DriftCheckAngle { get; set; } = 30f; 

    [JsonPropertyName("driftBodyHormingAngle_")]
    public float DriftBodyHormingAngle { get; set; } = 2f; 

    [JsonPropertyName("driftVectorHormingAngle_")]
    public float DriftVectorHormingAngle { get; set; } = 0.5f; 

    [JsonPropertyName("driftSpeedMag_")]
    public float DriftSpeedMag { get; set; } = 0.98f; 

    [JsonPropertyName("driftTransSpeed_")]
    public float DriftTransSpeed { get; set; } = 5f; 

    [JsonPropertyName("isTailSlash_")]
    public bool IsTailSlash { get; set; } = false; 

    [JsonPropertyName("iceCrushOffset_")]
    public Vector4 IceCrushOffset { get; set; } = new Vector4(0f, 0f, 6f, 1f); 

    [JsonPropertyName("isTutorialMotion_")]
    public bool IsTutorialMotion { get; set; } = false; 

    [JsonPropertyName("tutotialMotionLoopTime_")]
    public float TutotialMotionLoopTime { get; set; } = 2f; 
}



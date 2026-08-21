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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Elemental;

public class Em0900FireBeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0900FireBeamAction);

    [JsonPropertyName("fallGravity_")]
    public float FallGravity { get; set; } = 0.1f; 

    [JsonPropertyName("beamShotPosOffset_")]
    public Vector4 BeamShotPosOffset { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("jumpMotionMoveRate_")]
    public float JumpMotionMoveRate { get; set; } = 1.5f; 

    [JsonPropertyName("beamMoveDegY_")]
    public float BeamMoveDegY { get; set; } = 0f; 

    [JsonPropertyName("beamStartOffset_")]
    public Vector4 BeamStartOffset { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("beamMoveDist_")]
    public float BeamMoveDist { get; set; } = 8f; 

    [JsonPropertyName("backMoveDist_")]
    public float BackMoveDist { get; set; } = 10f; 

    [JsonPropertyName("defaultShotSize_")]
    public float DefaultShotSize { get; set; } = 0.5f; 

    [JsonPropertyName("defaultShotLandingTime_")]
    public float DefaultShotLandingTime { get; set; } = 0.2f; 

    [JsonPropertyName("defaultShotMoveWaitTime_")]
    public float DefaultShotMoveWaitTime { get; set; } = 0.3f; 

    [JsonPropertyName("defaultShotMoveTime_")]
    public float DefaultShotMoveTime { get; set; } = 0.3f; 

    [JsonPropertyName("defaultSpeedRateAddPower_")]
    public int DefaultSpeedRateAddPower { get; set; } = 0; 
}


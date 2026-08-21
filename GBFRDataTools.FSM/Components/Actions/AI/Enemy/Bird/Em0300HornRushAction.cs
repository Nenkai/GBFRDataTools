using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;
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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Bird;

public class Em0300HornRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0300HornRushAction);

    [JsonPropertyName("rushBegin_HomingAngle_")]
    public float RushBegin_HomingAngle { get; set; } = 2f; 

    [JsonPropertyName("rushBegin_Height_")]
    public float RushBegin_Height { get; set; } = 2f; 

    [JsonPropertyName("rushBegin_LeaveDistance_")]
    public float RushBegin_LeaveDistance { get; set; } = 3f; 

    [JsonPropertyName("rushBegin_AdjustTime_")]
    public float RushBegin_AdjustTime { get; set; } = 1f; 

    [JsonPropertyName("rushBegin_SighWidth_")]
    public float RushBegin_SighWidth { get; set; } = 3.5f; 

    [JsonPropertyName("rushLoop_StartSpeed_")]
    public float RushLoop_StartSpeed { get; set; } = 30f; 

    [JsonPropertyName("rushLoop_MaxSpeed_")]
    public float RushLoop_MaxSpeed { get; set; } = 40f; 

    [JsonPropertyName("rushLoop_MaxSpeedLength")]
    public float RushLoop_MaxSpeedLength { get; set; } = 10f; 

    [JsonPropertyName("rushLoop_TargetBackLength")]
    public float RushLoop_TargetBackLength { get; set; } = 5f; 

    [JsonPropertyName("rushLoop_NonTargetLength")]
    public float RushLoop_NonTargetLength { get; set; } = 20f; 

    [JsonPropertyName("rushLoop_CheckTransparentWallLength_")]
    public float RushLoop_CheckTransparentWallLength { get; set; } = 7.5f; 

    [JsonPropertyName("rushLoop_StartSubRushDirY_")]
    public float RushLoop_StartSubRushDirY { get; set; } = 0.01f; 

    [JsonPropertyName("rushLoop_AddSubRushDirY_")]
    public float RushLoop_AddSubRushDirY { get; set; } = 0.01f; 

    [JsonPropertyName("missStabTime_")]
    public float MissStabTime { get; set; } = 3f; 

    [JsonPropertyName("hitStabTime_")]
    public float HitStabTime { get; set; } = 1f; 
}

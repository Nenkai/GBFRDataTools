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
    public float RushBegin_HomingAngle { get; set; } = 2f; // Offset 0xEC

    [JsonPropertyName("rushBegin_Height_")]
    public float RushBegin_Height { get; set; } = 2f; // Offset 0xF0

    [JsonPropertyName("rushBegin_LeaveDistance_")]
    public float RushBegin_LeaveDistance { get; set; } = 3f; // Offset 0xF4

    [JsonPropertyName("rushBegin_AdjustTime_")]
    public float RushBegin_AdjustTime { get; set; } = 1f; // Offset 0xF8

    [JsonPropertyName("rushBegin_SighWidth_")]
    public float RushBegin_SighWidth { get; set; } = 3.5f; // Offset 0xFC

    [JsonPropertyName("rushLoop_StartSpeed_")]
    public float RushLoop_StartSpeed { get; set; } = 30f; // Offset 0x100

    [JsonPropertyName("rushLoop_MaxSpeed_")]
    public float RushLoop_MaxSpeed { get; set; } = 40f; // Offset 0x104

    [JsonPropertyName("rushLoop_MaxSpeedLength")]
    public float RushLoop_MaxSpeedLength { get; set; } = 10f; // Offset 0x108

    [JsonPropertyName("rushLoop_TargetBackLength")]
    public float RushLoop_TargetBackLength { get; set; } = 5f; // Offset 0x10C

    [JsonPropertyName("rushLoop_NonTargetLength")]
    public float RushLoop_NonTargetLength { get; set; } = 20f; // Offset 0x110

    [JsonPropertyName("rushLoop_CheckTransparentWallLength_")]
    public float RushLoop_CheckTransparentWallLength { get; set; } = 7.5f; // Offset 0x114

    [JsonPropertyName("rushLoop_StartSubRushDirY_")]
    public float RushLoop_StartSubRushDirY { get; set; } = 0.01f; // Offset 0x118

    [JsonPropertyName("rushLoop_AddSubRushDirY_")]
    public float RushLoop_AddSubRushDirY { get; set; } = 0.01f; // Offset 0x11C

    [JsonPropertyName("missStabTime_")]
    public float MissStabTime { get; set; } = 3f; // Offset 0x124

    [JsonPropertyName("hitStabTime_")]
    public float HitStabTime { get; set; } = 1f; // Offset 0x128

    public Em0300HornRushAction()
    {
    }
}

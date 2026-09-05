using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900JumpMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900JumpMoveAction);

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.1f; 

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1f; 

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 1f;

    [JsonPropertyName("signRadius_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public float SignRadius { get; set; } = 7.8f;

    [JsonPropertyName("isEndCancel_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public bool IsEndCancel { get; set; } = false;

    [JsonPropertyName("cancelTime_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public float CancelTime { get; set; } = 1f;

    [JsonPropertyName("isG3FinishCenterJump_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public bool IsG3FinishCenterJump { get; set; } = false;

    [JsonPropertyName("g3StageRadius_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public float G3StageRadius { get; set; } = 30f;

    [JsonPropertyName("isG3StageJump_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public bool IsG3StageJump { get; set; } = false;

    [JsonPropertyName("isG3TargetAnotherPlayer_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public bool IsG3TargetAnotherPlayer { get; set; } = false;

    [JsonPropertyName("isG3WaitPhase_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public bool IsG3WaitPhase { get; set; } = false;

    [JsonPropertyName("g3WaitModeSpeed_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public float G3WaitModeSpeed { get; set; } = 1.3f;
}



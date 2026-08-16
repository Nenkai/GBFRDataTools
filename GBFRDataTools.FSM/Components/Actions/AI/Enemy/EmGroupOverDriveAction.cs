using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

[GameSupport(GameVersion.EndlessRagnarok)]
public class EmGroupOverDriveAction : EmBossOverDriveAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmGroupOverDriveAction);

    [JsonPropertyName("isBeginOneOnOneMode_")]
    public bool IsBeginOneOnOneMode { get; set; } = false;

    [JsonPropertyName("cutinOffsetRotY")]
    public float CutinOffsetRotY { get; set; } = 0f;

    [JsonPropertyName("cutinOffsetRotYByHL_")]
    public float CutinOffsetRotYByHL { get; set; } = 0f;

    public EmGroupOverDriveAction()
    {
        InterSec = 0.2f;
    }
}

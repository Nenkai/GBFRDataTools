using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

[GameSupport(GameVersion.EndlessRagnarok)]
[Obsolete("Not exposed by the executable.")]
public class Em0010RunAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0010RunAction);

    [JsonPropertyName("runAnimSpd_")]
    public float RunAnimSpd { get; set; }

    [JsonPropertyName("turnStartSpd_")]
    public float TurnStartSpd { get; set; }

    [JsonPropertyName("turnAddSpd_")]
    public float TurnAddSpd { get; set; }

    [JsonPropertyName("runEndMinLength_")]
    public int RunEndMinLength { get; set; }

    [JsonPropertyName("runEndTime_")]
    public int RunEndTime { get; set; }

    [JsonPropertyName("checkHitMoveDist_")]
    public float CheckHitMoveDist { get; set; }

    [JsonPropertyName("hitedTurnScale_")]
    public float HitedTurnScale { get; set; }

    [JsonPropertyName("isMoveOffRunEnd_")]
    public bool IsMoveOffRunEnd { get; set; }

    [JsonPropertyName("motionIdRunStart_")]
    public string? MotionIdRunStart { get; set; }

    [JsonPropertyName("motionIdRunLoop_")]
    public string? MotionIdRunLoop { get; set; }

    [JsonPropertyName("motionIdRunEnd_")]
    public string? MotionIdrunEnd { get; set; }
}
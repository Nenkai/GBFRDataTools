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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200MoveTurnAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200MoveTurnAction);

    [JsonPropertyName("direction_")]
    public int Direction { get; set; } = 0;

    [JsonPropertyName("actType_")]
    public int ActType { get; set; } = 0;

    [JsonPropertyName("isAutoDir_")]
    public bool IsAutoDir { get; set; } = true;

    [JsonPropertyName("interTime_")]
    public float InterTime { get; set; } = -1f;

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; } = 1f;

    [JsonPropertyName("enableCheckTargetAngle_")]
    public bool EnableCheckTargetAngle { get; set; } = false;

    [JsonPropertyName("targetLeftAngleLowerLimit_")]
    public float TargetLeftAngleLowerLimit { get; set; } = 0f;

    [JsonPropertyName("targetLeftAngleUpperLimit_")]
    public float TargetLeftAngleUpperLimit { get; set; } = 180f;

    [JsonPropertyName("targetRightAngleLowerLimit_")]
    public float TargetRightAngleLowerLimit { get; set; } = 0f;

    [JsonPropertyName("targetRightAngleUpperLimit_")]
    public float TargetRightAngleUpperLimit { get; set; } = 180f;
}

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
public class Em8200MoveStepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200MoveStepAction);

    [JsonPropertyName("direction_")]
    public int Direction { get; set; } = 0;

    [JsonPropertyName("actType_")]
    public int ActType { get; set; } = 0;

    [JsonPropertyName("moveType_")]
    public int MoveType { get; set; } = 0;

    [JsonPropertyName("turnTargetAngleLowerLimit_")]
    public float TurnTargetAngleLowerLimit { get; set; } = 0f;

    [JsonPropertyName("turnTargetAngleUpperLimit_")]
    public float TurnTargetAngleUpperLimit { get; set; } = 0f;

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.1f;

    [JsonPropertyName("interFrame_")]
    public int InterFrame { get; set; } = 0;

    [JsonPropertyName("backStepTurnType_")]
    public int BackStepTurnType { get; set; } = 0;
}

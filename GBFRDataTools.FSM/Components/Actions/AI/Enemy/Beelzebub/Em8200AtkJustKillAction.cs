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
public class Em8200AtkJustKillAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200AtkJustKillAction);

    [JsonPropertyName("actType_")]
    public int ActType { get; set; } = 0;

    [JsonPropertyName("bindType_")]
    public Em8200AtkBindType BindType { get; set; } = 0;

    [JsonPropertyName("targetAngleLowerLimit_")]
    public float TargetAngleLowerLimit { get; set; } = -90f;

    [JsonPropertyName("targetAngleUpperLimit_")]
    public float TargetAngleUpperLimit { get; set; } = 90f;
}
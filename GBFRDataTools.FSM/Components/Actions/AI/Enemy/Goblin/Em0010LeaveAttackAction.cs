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
public class Em0010LeaveAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0010LeaveAttackAction);

    [JsonPropertyName("motionId_")]
    public string? MotionId { get; set; }

    [JsonPropertyName("animSpd_")]
    public float AnimSpd { get; set; }

    [JsonPropertyName("homingMaxAngle_")]
    public float HomingMaxAngle { get; set; }

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; }
}
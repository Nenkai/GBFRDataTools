using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Gallanza;

public class Em2000ShotShowAttackAreaMoveStraightAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000ShotShowAttackAreaMoveStraightAction);

    [JsonPropertyName("velocity_")]
    public float Velocity { get; set; } = 0.0f;

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 0.0f;

    [JsonPropertyName("isUseOverrideVelocity_")]
    public bool IsUseOverrideVelocity { get; set; } = false;
}

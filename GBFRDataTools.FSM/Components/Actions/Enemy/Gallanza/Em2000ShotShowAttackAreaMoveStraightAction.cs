using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Gallanza;

public class Em2000ShotShowAttackAreaMoveStraightAction : ActionComponent
{
    [JsonPropertyName("velocity_")]
    public float Velocity { get; set; }

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; }

    [JsonPropertyName("isUseOverrideVelocity_")]
    public bool IsUseOverrideVelocity { get; set; }
}

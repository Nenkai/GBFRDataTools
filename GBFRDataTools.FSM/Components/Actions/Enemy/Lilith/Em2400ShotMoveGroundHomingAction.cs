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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Lilith;

public class Em2400ShotMoveGroundHomingAction : ActionComponent
{
    [JsonPropertyName("maxSpeed_")]
    public float MaxSpeed { get; set; } = 0.0f;

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 0.0f;
}

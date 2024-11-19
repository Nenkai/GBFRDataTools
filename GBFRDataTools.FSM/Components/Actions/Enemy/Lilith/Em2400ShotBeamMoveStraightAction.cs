using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Lilith;

public class Em2400ShotBeamMoveStraightAction : ActionComponent
{
    [JsonPropertyName("velocity_")]
    public float Velocity { get; set; }

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; }
}

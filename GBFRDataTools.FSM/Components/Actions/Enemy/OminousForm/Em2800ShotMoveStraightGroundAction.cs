using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.OminousForm;

public class Em2800ShotMoveStraightGroundAction : Em0500SplineAction
{
    [JsonPropertyName("maxSpeed_")]
    public float MaxSpeed { get; set; } = 0.0f;

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 0.0f;
}

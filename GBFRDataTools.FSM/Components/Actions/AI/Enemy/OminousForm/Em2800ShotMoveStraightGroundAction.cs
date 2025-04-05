using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.OminousForm;

public class Em2800ShotMoveStraightGroundAction : Em0500SplineAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2800ShotMoveStraightGroundAction);

    [JsonPropertyName("maxSpeed_")]
    public float MaxSpeed { get; set; } = 0.0f;

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 0.0f;
}

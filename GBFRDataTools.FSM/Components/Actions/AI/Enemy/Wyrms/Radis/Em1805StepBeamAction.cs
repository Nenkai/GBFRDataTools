using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Radis;

public class Em1805StepBeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805StepBeamAction);

    [JsonPropertyName("homingTime_")]
    public float HomingTime { get; set; } = 0.5f; 

    [JsonPropertyName("homingAng_")]
    public float HomingAng { get; set; } = 80f; 
}



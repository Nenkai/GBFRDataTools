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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wolf;

public class Em0200MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200MoveToAction);

    [JsonPropertyName("frontRunEndDistance_")]
    public float FrontRunEndDistance { get; set; } = 4f; 

    [JsonPropertyName("frontRunEndAngle_")]
    public float FrontRunEndAngle { get; set; } = 180f; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.02f; 

    [JsonPropertyName("isForceAttack_")]
    public bool IsForceAttack { get; set; } = false; 
}

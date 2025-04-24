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

public class Em0200RiderDoubleRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200RiderDoubleRushAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.02f; // Offset 0x34

    [JsonPropertyName("rushSpeed_")]
    public float RushSpeed { get; set; } = 0.4f; // Offset 0x38

    [JsonPropertyName("targetFrontLength_")]
    public float TargetFrontLength { get; set; } = 1f; // Offset 0x3C

    public Em0200RiderDoubleRushAction()
    {
    }
}

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

public class Em0200RiderDashAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200RiderDashAction);

    [JsonPropertyName("frontRunEndDistance_")]
    public float FrontRunEndDistance { get; set; } = 4f; // Offset 0x34

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.02f; // Offset 0x38

    [JsonPropertyName("leftMoveRate_")]
    public float LeftMoveRate { get; set; } = 1f; // Offset 0x3C

    public Em0200RiderDashAction()
    {
    }
}

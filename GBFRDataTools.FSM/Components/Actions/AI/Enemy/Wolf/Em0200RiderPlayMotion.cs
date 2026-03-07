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

public class Em0200RiderPlayMotion : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200RiderPlayMotion);

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; } // Offset 0x30

    [JsonPropertyName("loop_")]
    public bool Loop { get; set; } = false; // Offset 0x38

    public Em0200RiderPlayMotion()
    {
    }
}

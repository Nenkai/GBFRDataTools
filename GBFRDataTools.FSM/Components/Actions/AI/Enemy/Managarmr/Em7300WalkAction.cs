using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300WalkAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300WalkAction);

    [JsonPropertyName("dir_")]
    public int Dir { get; set; } = 0; // Offset 0x40

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 4f; // Offset 0x44

    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 4f; // Offset 0x48

    public Em7300WalkAction()
    {
    }
}

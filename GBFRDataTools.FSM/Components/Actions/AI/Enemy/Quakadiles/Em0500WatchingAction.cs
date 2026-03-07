using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500WatchingAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500WatchingAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 4f; // Offset 0x48

    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 4f; // Offset 0x4C

    [JsonPropertyName("moveType_")]
    public int MoveType { get; set; } = 0; // Offset 0x44

    public Em0500WatchingAction()
    {
    }
}
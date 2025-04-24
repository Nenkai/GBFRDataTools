using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyvern;

public class Em0400FlyAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0400FlyAction);

    [JsonPropertyName("distanceXZ_")]
    public float DistanceXZ { get; set; } = 0f; // Offset 0x40

    [JsonPropertyName("distanceY_")]
    public float DistanceY { get; set; } = 0f; // Offset 0x44

    [JsonPropertyName("isHeightOnly_")]
    public bool IsHeightOnly { get; set; } = false; // Offset 0x4C

    [JsonPropertyName("isWaitStop_")]
    public bool IsWaitStop { get; set; } = false; // Offset 0x4D

    public Em0400FlyAction()
    {
    }
}

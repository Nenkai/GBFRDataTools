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
    public float DistanceXZ { get; set; } = 0f; 

    [JsonPropertyName("distanceY_")]
    public float DistanceY { get; set; } = 0f; 

    [JsonPropertyName("isHeightOnly_")]
    public bool IsHeightOnly { get; set; } = false; 

    [JsonPropertyName("isWaitStop_")]
    public bool IsWaitStop { get; set; } = false; 
}

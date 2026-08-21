using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmSearchAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmSearchAction);

    [JsonPropertyName("animationNameWalk_")]
    public string? AnimationNameWalk { get; set; } 

    [JsonPropertyName("waitLen_")]
    public float WaitLen { get; set; } = 1f; 

    [JsonPropertyName("isFly_")]
    public bool IsFly { get; set; } = false; 

    [JsonPropertyName("flySpeed_")]
    public float FlySpeed { get; set; } = 0f; 
}

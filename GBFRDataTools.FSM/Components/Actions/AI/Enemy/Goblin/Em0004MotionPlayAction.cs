using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004MotionPlayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004MotionPlayAction);

    [JsonPropertyName("motionIdName_")]
    public string? MotionIdName { get; set; } 

    [JsonPropertyName("loop_")]
    public bool Loop { get; set; } = false; 

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = 0f; 

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = 0.1f; 

    [JsonPropertyName("endSecond_")]
    public float EndSecond { get; set; } = -1f; 
}

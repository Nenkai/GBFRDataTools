using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500BackAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500BackAction);

    [JsonPropertyName("homingAngleFront_")]
    public float HomingAngleFront { get; set; } = 8f; 

    [JsonPropertyName("homingAngleLR_")]
    public float HomingAngleLR { get; set; } = 5f; 

    [JsonPropertyName("homingAngleBack_")]
    public float HomingAngleBack { get; set; } = 3f; 

    [JsonPropertyName("endSecond_")]
    public float EndSecond { get; set; } = 1f; 

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1f; 

    [JsonPropertyName("useDragMotion_")]
    public bool UseDragMotion { get; set; } = true; 

    [JsonPropertyName("magmaConfront_")]
    public bool MagmaConfront { get; set; } = false; 
}



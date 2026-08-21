using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Golem;

public class Em1500BindAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500BindAttackAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; 

    [JsonPropertyName("moveLoopMax_")]
    public int MoveLoopMax { get; set; } = 3; 

    [JsonPropertyName("bindStartRange_")]
    public float BindStartRange { get; set; } = 2f; 

    [JsonPropertyName("bindOffsetX_")]
    public float BindOffsetX { get; set; } = -0.5f; 

    [JsonPropertyName("bindOffsetY_")]
    public float BindOffsetY { get; set; } = 0f; 

    [JsonPropertyName("bindOffsetZ_")]
    public float BindOffsetZ { get; set; } = 0.5f; 
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100SwordBrokenAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100SwordBrokenAction);

    [JsonPropertyName("fallingMaxTime_")]
    public float FallingMaxTime { get; set; } = 3f; 

    [JsonPropertyName("fallingXZRand_")]
    public float FallingXZRand { get; set; } = 3f; 

    [JsonPropertyName("fallingYRandMin_")]
    public float FallingYRandMin { get; set; } = 5f; 

    [JsonPropertyName("fallingYRandMax_")]
    public float FallingYRandMax { get; set; } = 7f; 

    [JsonPropertyName("fallingGraviryRate_")]
    public float FallingGraviryRate { get; set; } = 1.2f; 

    [JsonPropertyName("fallingPitchRate_")]
    public float FallingPitchRate { get; set; } = 2f; 

    [JsonPropertyName("fallingYawRate_")]
    public float FallingYawRate { get; set; } = 3f; 
}

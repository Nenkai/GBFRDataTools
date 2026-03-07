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
    public float FallingMaxTime { get; set; } = 3f; // Offset 0x11C

    [JsonPropertyName("fallingXZRand_")]
    public float FallingXZRand { get; set; } = 3f; // Offset 0x120

    [JsonPropertyName("fallingYRandMin_")]
    public float FallingYRandMin { get; set; } = 5f; // Offset 0x124

    [JsonPropertyName("fallingYRandMax_")]
    public float FallingYRandMax { get; set; } = 7f; // Offset 0x128

    [JsonPropertyName("fallingGraviryRate_")]
    public float FallingGraviryRate { get; set; } = 1.2f; // Offset 0x12C

    [JsonPropertyName("fallingPitchRate_")]
    public float FallingPitchRate { get; set; } = 2f; // Offset 0x130

    [JsonPropertyName("fallingYawRate_")]
    public float FallingYawRate { get; set; } = 3f; // Offset 0x134

    public Em2100SwordBrokenAction()
    {
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0800CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0800CounterAction);

    [JsonPropertyName("signTime_")]
    public float SignTime { get; set; } = 4f; // Offset 0x30

    [JsonPropertyName("signRadius_")]
    public float SignRadius { get; set; } = 2f; // Offset 0x34

    [JsonPropertyName("coreEstId_")]
    public int CoreEstId { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("effectScale_")]
    public float EffectScale { get; set; } = 1f; // Offset 0x3C

    [JsonPropertyName("escapeRate_")]
    public float EscapeRate { get; set; } = 1f; // Offset 0x40

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 0f; // Offset 0x44

    public Em0800CounterAction()
    {
    }
}
